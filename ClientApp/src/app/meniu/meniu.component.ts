import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Meniu } from './meniu-models';


@Component({
  selector: 'app-meniu',
  templateUrl: './meniu.component.html',
  styleUrls: ['./meniu.component.css']
})
export class MeniuComponent {

  public meniuri: Meniu[];


  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {
    this.loadMeniuri();
  }

  public deleteMeniu(meniu: Meniu) {
    this.http.delete(this.baseUrl + 'api/meniuri/' + meniu.id).subscribe(result => {
      this.loadMeniuri();
    }, error => console.error(error))
  }

  loadMeniuri() {
    this.http.get<Meniu[]>(this.baseUrl + 'api/meniuri').subscribe(result => {
      this.meniuri = result;
    }, error => console.error(error));
  }
}


