import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Comanda } from './comanda-models';
import { Router } from '@angular/router';


@Component({
  selector: 'app-comanda-add',
  templateUrl: './comanda-add.component.html',
  styleUrls: ['./comanda.component.css']
})
export class ComandaAddComponent  {

  public comanda: Comanda ;

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string,
    private router: Router) { this.comanda = <Comanda>{}; }

  public saveComanda() {
    this.http.post(this.baseUrl + 'api/comenzi', this.comanda).subscribe(result => {
      this.router.navigateByUrl("/comenzi");
    }, error => console.error(error))
  }
}


