import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router'; 
import { SharedModule } from '../../shared/shared.module';
import { CategoriesComponent } from './categories/categories.component'; 
import { ListComponent } from './list/list.component';
import { DetailComponent } from './detail/detail.component';
import { AddComponent } from './add/add.component';
import { CategoryDialogComponent } from './categories/category-dialog/category-dialog.component';
import { RolesComponent } from './roles/roles.component';
import { GroupsComponent } from './groups/groups.component';
import { RoleDialogComponent } from './roles/role-dialog/role-dialog.component';
import { GroupDialogComponent } from './groups/group-dialog/group-dialog.component';

export const routes = [ 
  { path: '', redirectTo: 'list', pathMatch: 'full'},
  { path: 'roles', component: RolesComponent, data: { breadcrumb: 'Roles' } },
  { path: 'groups', component: GroupsComponent, data: { breadcrumb: 'Groups' } },
  { path: 'categories', component: CategoriesComponent, data: { breadcrumb: 'Categories' } },
  { path: 'list', component: ListComponent, data: { breadcrumb: 'Menu Items' } },
  { path: 'detail', component: DetailComponent, data: { breadcrumb: 'Menu Item Detail' } },
  { path: 'detail/:id', component: DetailComponent, data: { breadcrumb: 'Menu Item Detail' } }, 
  { path: 'add', component: AddComponent, data: { breadcrumb: 'Add Menu Item' } },
  { path: 'add/:id', component: AddComponent, data: { breadcrumb: 'Edit Menu Item' } }, 
];

@NgModule({
  declarations: [
    CategoriesComponent, 
    ListComponent, 
    DetailComponent, 
    AddComponent, CategoryDialogComponent, RolesComponent, GroupsComponent, RoleDialogComponent, GroupDialogComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(routes),
    SharedModule
  ]
})
export class MenuItemsModule { }
