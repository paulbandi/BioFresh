import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Meniu } from './meniu-models';
import { Router } from '@angular/router';


@Component({
  selector: 'app-meniu-add',
  templateUrl: './meniu-add.component.html',
  styleUrls: ['./meniu.component.css']
})
export class MeniuAddComponent  {

  public meniu: Meniu ;

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string,
    private router: Router) { this.meniu = <Meniu>{}; }

  public saveMeniu() {
    this.http.post(this.baseUrl + 'api/meniuri', this.meniu).subscribe(result => {
      this.router.navigateByUrl("/meniuri");
    }, error => console.error(error))
  }
}


