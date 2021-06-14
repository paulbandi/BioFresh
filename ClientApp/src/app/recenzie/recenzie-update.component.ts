import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Recenzie } from './recenzie-models';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-recenzie-update',
  templateUrl: './recenzie-update.component.html',
  styleUrls: ['./recenzie.component.css']
})
export class RecenzieUpdateComponent  {

  public recenzie: Recenzie;
  public param;

  ngOnInit() {
    this.routers.queryParams.subscribe(param => {
      this.param = param;
      this.loadRecenzie();
    });
  }
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private routers: ActivatedRoute, private router: Router) { }

  loadRecenzie() {
    this.http.get<Recenzie>(this.baseUrl + 'api/recenzii/' + this.param.id).subscribe(result => {
      this.recenzie = result;
    }, error => console.error(error));
  }

  public saveRecenzie() {
    this.http.put(this.baseUrl + 'api/recenzii/' + this.recenzie.id, this.recenzie).subscribe(result => {
      this.router.navigateByUrl("/recenzii");
    }, error => console.error(error));
  }
}


