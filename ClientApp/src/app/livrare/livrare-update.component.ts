import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Livrare } from './livrare-models';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-livrare-update',
  templateUrl: './livrare-update.component.html',
  styleUrls: ['./livrare.component.css']
})
export class LivrareUpdateComponent  {

  public livrare: Livrare;
  public param;

  ngOnInit() {
    this.routers.queryParams.subscribe(param => {
      this.param = param;
      this.loadLivrare();
    });
  }
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private routers: ActivatedRoute, private router: Router) { }

  loadLivrare() {
    this.http.get<Livrare>(this.baseUrl + 'api/livrari/' + this.param.id).subscribe(result => {
      this.livrare = result;
    }, error => console.error(error));
  }

  public saveLivrare() {
    this.http.put(this.baseUrl + 'api/livrari/' + this.livrare.id, this.livrare).subscribe(result => {
      this.router.navigateByUrl("/livrari");
    }, error => console.error(error));
  }
}


