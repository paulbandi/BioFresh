import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Meniu } from './meniu-models';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-meniu-update',
  templateUrl: './meniu-update.component.html',
  styleUrls: ['./meniu.component.css']
})
export class MeniuUpdateComponent  {

  public meniu: Meniu;
  public param;

  ngOnInit() {
    this.routers.queryParams.subscribe(param => {
      this.param = param;
      this.loadMeniu();
    });
  }
  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string, private routers: ActivatedRoute, private router: Router) { }

  loadMeniu() {
    this.http.get<Meniu>(this.baseUrl + 'api/meniuri/' + this.param.id).subscribe(result => {
      this.meniu = result;
    }, error => console.error(error));
  }

  public saveMeniu() {
    this.http.put(this.baseUrl + 'api/meniuri/' + this.meniu.id, this.meniu).subscribe(result => {
      this.router.navigateByUrl("/meniuri");
    }, error => console.error(error));
  }
}


