import { Component, OnInit, ChangeDetectorRef, ViewChild } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { MatSnackBar } from '@angular/material/snack-bar';

import { TdLoadingService } from '@covalent/core/loading';
import { TdDialogService } from '@covalent/core/dialogs';
import { TdMediaService } from '@covalent/core/media';
import { customPaginator } from '../custom/customPaginator';

import { MatTableFilter } from 'mat-table-filter';
import { MatPaginator, MatPaginatorIntl } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';

import { EstructuraService, Estructura, IEstructura } from './services/estructura.service';
import { MatTableDataSource } from '@angular/material/table';
import { CryptoService } from 'src/services/crypto.services';


import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'qs-estructura',
  templateUrl: './estructura.component.html',
  styleUrls: ['./estructura.component.scss'],
  providers: [{ provide: MatPaginatorIntl, useValue: customPaginator() }]
})
export class EstructuraComponent implements OnInit {

  filterEntity: Estructura;
  filterType: MatTableFilter;
  displayedColumns = ['Desc_Estructura', 'Fecha_InicioVigencia', 'Fecha_FinVigencia',
    'Cb_EsDefinitiva', 'Nombre_UsuarioCreacion', 'Fecha_Creacion', 'Editar', 'Eliminar'];

  dataSource: MatTableDataSource<IEstructura>;
  estructuras: IEstructura[];
  filteredEstructuras: IEstructura[];
  isLoading: boolean = true;
  estructura: Estructura;

  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  constructor(
    private _titleService: Title,
    private _loadingService: TdLoadingService,
    private _dialogService: TdDialogService,
    private _snackBarService: MatSnackBar,
    private _estructuraService: EstructuraService,
    private _changeDetectorRef: ChangeDetectorRef,
    public media: TdMediaService,
    private _cryptoService: CryptoService,
    private _route: ActivatedRoute,
    private _router: Router
  ) { }

  ngOnInit(): void {

      try {
        if (sessionStorage.getItem('User')) {
          this._titleService.setTitle('Estructuras');
          this.filterEntity = new Estructura();
          this.filterType = MatTableFilter.ANYWHERE;
          this.load();
      }  else 
      {
      this._router.navigate(['frmlogin']);
      }
    }
    catch (error) {
      this._router.navigate(['error']);
    }
}

  async load(): Promise<void> {
    try {
      this._loadingService.register('estructuras.list');
      this.isLoading = true;
      this.estructuras = await this._estructuraService.getEstructuras().toPromise();
      
    } catch (error) {
      //console.log(error);
      this._dialogService.openAlert({ message: 'Ocurrió un error Ingresando:' + error, closeButton: 'Aceptar' });
    
    } finally {
      this.filteredEstructuras = Object.assign([], this.estructuras);
      this.dataSource = new MatTableDataSource(this.filteredEstructuras);
      this.afterViewInit();
      this._changeDetectorRef.detectChanges();
      this.isLoading = false;
      this._loadingService.resolve('estructuras.list');
    }
  }

  afterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;

    //sort no case sensitive way
    this.dataSource.sortingDataAccessor = (data: any, sortHeaderId: string): string => {
      if (typeof data[sortHeaderId] === 'string') {
        return data[sortHeaderId].toLocaleLowerCase();
      }
      return data[sortHeaderId];
    };
  }

  delete(Id_Estructura: number, Desc_Estructura: string): void {
    this._dialogService
      .openConfirm({
        message: '¿Está seguro de borrar esta Estructura?',
        acceptButton: 'Aceptar'
      })
      .afterClosed().toPromise().then((confirm: boolean) => {
        if (confirm) {
          this._delete(Id_Estructura, Desc_Estructura);
        }
      });
  }

  private async _delete(Id_Estructura: number, Desc_Estructura: string): Promise<void> {
    try {
      this._loadingService.register('estructuras.list');
      let estructuras: IEstructura[] = await this._estructuraService.getEstructuraByIdName(Id_Estructura, Desc_Estructura).toPromise();

      if (sessionStorage.getItem('Menus')) {
        let Nombre_UsuarioEliminacion = this._cryptoService.decryptText(sessionStorage.getItem('User').toString()).replace(/['"]+/g, '');
        let perfil = this._cryptoService.decryptText(sessionStorage.getItem('perfil').toString()).replace(/['"]+/g, '');
        
        let estructura = {
          Id_Estructura: estructuras[0].Id_Estructura,
          Cb_Eliminado: 'S',
          Cb_EsDefinitiva: estructuras[0].Cb_EsDefinitiva,
          Desc_Estructura: estructuras[0].Desc_Estructura,
          Fecha_Creacion: estructuras[0].Fecha_Creacion,
          Fecha_FinVigencia: estructuras[0].Fecha_FinVigencia,
          Fecha_InicioVigencia: estructuras[0].Fecha_InicioVigencia,
          Nombre_UsuarioCreacion: Nombre_UsuarioEliminacion,
          Nombre_UsuarioEliminacion: Nombre_UsuarioEliminacion,
          Nodos: null,
          perfil: perfil
        }
      
        let resultPut = await this._estructuraService.putUpdateEstructura(Id_Estructura, estructura).toPromise();
        if (resultPut < 0) {
          this._snackBarService.open('Error guardando estructura guardada', 'Ok', { duration: 2000 });
        }  else if (resultPut == 98) {
          this._snackBarService.open('La Estructura no se puede eliminar, no es el usuario que la creo' ,'Ok', { duration: 4000 });
        }else{  this.estructuras = this.estructuras.filter((estructuras: IEstructura) => {
          return estructuras.Id_Estructura !== Id_Estructura;
        });
        this.filteredEstructuras = this.filteredEstructuras.filter((estructura: IEstructura) => {
          return estructura.Id_Estructura !== Id_Estructura;
        });
        this.dataSource = new MatTableDataSource(this.filteredEstructuras);
        this._changeDetectorRef.detectChanges();
        this._snackBarService.open('Estructura Eliminada', 'Ok', { duration: 2000 });}
      
      } else {
        this._dialogService.openAlert({ message: 'Ocurrió un error eliminando la estructura: Usuario No autorizado', closeButton: 'Aceptar' });
      }
    } catch (error) {
      //console.log(error);
      this._dialogService.openAlert({ message: 'Ocurrió un error eliminando la estructura:' + error, closeButton: 'Aceptar' });
    } finally {
      this._loadingService.resolve('estructuras.list');
    }
  }

  applyFilter(data: Estructura, filter: any) {

    let filters = Object.getOwnPropertyNames(filter);
    let isMatch = true;

    filters.forEach(element => {
      let valueProperty = data[element] || "";
      let type = typeof valueProperty
      let filterValue = (filter[element] || "") as string

      isMatch = isMatch && ((valueProperty as string).toLowerCase().includes(filterValue));

    });

    return isMatch;
  }
}
