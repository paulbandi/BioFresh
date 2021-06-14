import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Recenzie } from './recenzie-models';
import { Router } from '@angular/router';


@Component({
  selector: 'app-recenzie-add',
  templateUrl: './recenzie-add.component.html',
  styleUrls: ['./recenzie.component.css']
})
export class RecenzieAddComponent  {

  public recenzie: Recenzie;

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string,
    private router: Router) { this.recenzie = <Recenzie>{}; }

  public saveRecenzie() {
    this.http.post(this.baseUrl + 'api/recenzii', this.recenzie).subscribe(result => {
      this.router.navigateByUrl("/recenzii");
    }, error => console.error(error))
  }
}


