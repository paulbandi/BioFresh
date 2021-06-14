import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Livrare } from './livrare-models';


@Component({
  selector: 'app-livrare',
  templateUrl: './livrare.component.html',
  styleUrls: ['./livrare.component.css']
})
export class LivrareComponent {

  public livrari: Livrare[];


  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.loadLivrari();
  }

  public deleteLivrare(livrare: Livrare) {
    this.http.delete(this.baseUrl + 'api/livrari/' + livrare.id).subscribe(result => {
      this.loadLivrari();
    }, error => console.error(error))
  }

  loadLivrari() {
    this.http.get<Livrare[]>(this.baseUrl + 'api/livrari').subscribe(result => {
      this.livrari = result;
    }, error => console.error(error));
  }
}


