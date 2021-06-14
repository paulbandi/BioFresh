import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Recenzie } from './recenzie-models';


@Component({
  selector: 'app-recenzie',
  templateUrl: './recenzie.component.html',
  styleUrls: ['./recenzie.component.css']
})
export class RecenzieComponent {

  public recenzii: Recenzie[];


  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.loadRecenzii();
  }

  public deleteRecenzie(recenzie: Recenzie) {
    this.http.delete(this.baseUrl + 'api/recenzii/' + recenzie.id).subscribe(result => {
      this.loadRecenzii();
    }, error => console.error(error))
  }

  loadRecenzii() {
    this.http.get<Recenzie[]>(this.baseUrl + 'api/recenzii').subscribe(result => {
      this.recenzii = result;
    }, error => console.error(error));
  }
}


