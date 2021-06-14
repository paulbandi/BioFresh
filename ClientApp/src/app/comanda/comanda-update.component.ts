import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Comanda } from './comanda-models';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-comanda-update',
  templateUrl: './comanda-update.component.html',
  styleUrls: ['./comanda.component.css']
})
export class ComandaUpdateComponent  {

  public comanda: Comanda;
  public param;

  ngOnInit() {
    this.routers.queryParams.subscribe(param => {
      this.param = param;
      this.loadComanda();
    });
  }
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private routers: ActivatedRoute, private router: Router) { }

  loadComanda() {
    this.http.get<Comanda>(this.baseUrl + 'api/comenzi/' + this.param.id).subscribe(result => {
      this.comanda = result;
    }, error => console.error(error));
  }

  public saveComanda() {
    this.http.put(this.baseUrl + 'api/comenzi/' + this.comanda.id, this.comanda).subscribe(result => {
      this.router.navigateByUrl("/comenzi");
    }, error => console.error(error));
  }
}


