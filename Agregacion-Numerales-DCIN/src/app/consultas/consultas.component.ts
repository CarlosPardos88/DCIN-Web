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

import { PeriodicidadConsultasService} from './services/PeriodicidadConsultas.service';
import { MatTableDataSource } from '@angular/material/table';
import { CryptoService } from 'src/services/crypto.services';
import { ConsultaagregacionService, Consulta, IConsulta } from './services/consultaagregacion.service';
import { IconOptions } from '@angular/material/icon';



import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'qs-consultas',
  templateUrl: './consultas.component.html',
  styleUrls: ['./consultas.component.scss'],
  providers: [{ provide: MatPaginatorIntl, useValue: customPaginator() }]
})
export class ConsultasComponent implements OnInit {

  filterEntity: Consulta;
  filterType: MatTableFilter;
  displayedColumns = ['Desc_Estructura', 'Fecha_Consulta', 'Desc_Fuente',
  'Fecha_Inicial', 'Fecha_Final', 'Desc_Periodicidad', 'Nombre_UsuarioCreacion', 'Ver'];

  dataSource: MatTableDataSource<IConsulta>;
  consultas: IConsulta[];
  filteredConsultas: IConsulta[];
  isLoading: boolean = true;

  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  constructor(
    private _titleService: Title,
    private _loadingService: TdLoadingService,
    private _dialogService: TdDialogService,
    private _snackBarService: MatSnackBar,
    private _changeDetectorRef: ChangeDetectorRef,
    public media: TdMediaService,
    private _cryptoService: CryptoService,
    private _ConsultaService: ConsultaagregacionService,
    private _route: ActivatedRoute,
    private _router: Router
  ) { }

  ngOnInit(): void {
    
      //let usuario = "";
      try {
        if (sessionStorage.getItem('User')) {
          this._titleService.setTitle('Consultas');
          this.filterEntity = new Consulta();
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
      this._loadingService.register('consultas.list');
      this.isLoading = true;
      this.consultas = await this._ConsultaService.getConsultaAgregacion().toPromise();
      
    } catch (error) {
      //console.log(error);
      this._dialogService.openAlert({ message: 'Ocurrió un error Ingresando:' + error, closeButton: 'Aceptar' });
    
    } finally {
      this.filteredConsultas = Object.assign([], this.consultas);
      this.dataSource = new MatTableDataSource(this.filteredConsultas);
      this.afterViewInit();
      this._changeDetectorRef.detectChanges();
      this.isLoading = false;
      this._loadingService.resolve('consultas.list');
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
}
