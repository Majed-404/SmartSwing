import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddMailsComponent } from './add-mails/add-mails.component';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgxPaginationModule } from 'ngx-pagination';
import { SharedModule } from 'src/app/shared/shared.module';
import { PipesModule } from 'src/app/theme/pipes/pipes.module';
import { QuillModule } from 'ngx-quill';

export const routes = [
  { path: '', component: AddMailsComponent, pathMatch: 'full' }
];

@NgModule({
  declarations: [AddMailsComponent],
  imports: [
    CommonModule,
    HttpClientModule,
    RouterModule.forChild(routes),
    FormsModule,
    ReactiveFormsModule,
    // InMemoryWebApiModule.forRoot(UsersData, { delay: 500 }),
    NgxPaginationModule,
    SharedModule,
    PipesModule,
    QuillModule.forRoot()  
  ]
})
export class AddMailsModule { }
