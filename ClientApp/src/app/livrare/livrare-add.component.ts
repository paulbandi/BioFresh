import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Livrare } from './livrare-models';
import { Router } from '@angular/router';


@Component({
  selector: 'app-livrare-add',
  templateUrl: './livrare-add.component.html',
  styleUrls: ['./livrare.component.css']
})
export class LivrareAddComponent  {

  public livrare: Livrare ;

  constructor(
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string,
    private router: Router) { this.livrare = <Livrare>{}; }

  public saveLivrare() {
    this.http.post(this.baseUrl + 'api/livrari', this.livrare).subscribe(result => {
      this.router.navigateByUrl("/livrari");
    }, error => console.error(error))
  }
}


