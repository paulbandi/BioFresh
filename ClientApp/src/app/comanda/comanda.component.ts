import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Comanda } from './comanda-models';


@Component({
  selector: 'app-comanda',
  templateUrl: './comanda.component.html',
  styleUrls: ['./comanda.component.css']
})
export class ComandaComponent {

  public comenzi: Comanda[];


  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.loadComenzi();
  }

  public deleteComanda(comanda: Comanda) {
    this.http.delete(this.baseUrl + 'api/comenzi/' + comanda.id).subscribe(result => {
      this.loadComenzi();
    }, error => console.error(error))
  }

  loadComenzi() {
    this.http.get<Comanda[]>(this.baseUrl + 'api/comenzi').subscribe(result => {
      this.comenzi = result;
    }, error => console.error(error));
  }
}


