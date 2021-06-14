import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ClientComponent } from './client/client.component';
import { ClientAddComponent } from './client/client-add.component';
import { ClientUpdateComponent } from './client/client-update.component';
import { MeniuComponent } from './meniu/meniu.component';
import { MeniuAddComponent } from './meniu/meniu-add.component';
import { MeniuUpdateComponent } from './meniu/meniu-update.component';
import { ComandaComponent } from './comanda/comanda.component';
import { ComandaAddComponent } from './comanda/comanda-add.component';
import { ComandaUpdateComponent } from './comanda/comanda-update.component';
import { LivrareComponent } from './livrare/livrare.component';
import { LivrareAddComponent } from './livrare/livrare-add.component';
import { LivrareUpdateComponent } from './livrare/livrare-update.component';
import { RecenzieComponent } from './recenzie/recenzie.component';
import { RecenzieAddComponent } from './recenzie/recenzie-add.component';
import { RecenzieUpdateComponent } from './recenzie/recenzie-update.component'

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ClientComponent,
    ClientAddComponent,
    ClientUpdateComponent,
    MeniuComponent,
    MeniuAddComponent,
    MeniuUpdateComponent,
    ComandaComponent,
    ComandaAddComponent,
    ComandaUpdateComponent,
    LivrareComponent,
    LivrareAddComponent,
    LivrareUpdateComponent,
    RecenzieComponent,
    RecenzieAddComponent,
    RecenzieUpdateComponent

  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
    { path: '', component: HomeComponent, pathMatch: 'full' },
    { path: 'counter', component: CounterComponent },
    { path: 'fetch-data', component: FetchDataComponent },
      { path: 'clienti', component: ClientComponent },
      { path: 'client-add', component: ClientAddComponent },
      { path: 'client-update', component: ClientUpdateComponent },
      { path: 'meniuri', component: MeniuComponent },
      { path: 'meniu-add', component: MeniuAddComponent },
      { path: 'meniu-update', component: MeniuUpdateComponent },
      { path: 'comenzi', component: ComandaComponent },
      { path: 'comanda-add', component: ComandaAddComponent },
      { path: 'comanda-update', component: ComandaUpdateComponent },
      { path: 'livrari', component: LivrareComponent },
      { path: 'livrare-add', component: LivrareAddComponent },
      { path: 'livrare-update', component: LivrareUpdateComponent },
      { path: 'recenzii', component: RecenzieComponent },
      { path: 'recenzie-add', component: RecenzieAddComponent },
      { path: 'recenzie-update', component: RecenzieUpdateComponent }
], { relativeLinkResolution: 'legacy' })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
