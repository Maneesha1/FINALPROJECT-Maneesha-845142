import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BuyerComponent } from './buyer/buyer/buyer.component';
import { SearchComponent } from './buyer/search/search.component';
import { ViewcartComponent } from './buyer/viewcart/viewcart.component';
import { PurchaseHistoryComponent } from './buyer/purchase-history/purchase-history.component';
import { ViewbuyerprofileComponent } from './buyer/viewbuyerprofile/viewbuyerprofile.component';
import { ViewsellerprofileComponent } from './seller/viewsellerprofile/viewsellerprofile.component';

import { SellerComponent } from './seller/seller/seller.component';
import { AdditemsComponent } from './seller/additems/additems.component';
import { ViewitemsComponent } from './seller/viewitems/viewitems.component';
import { ViewreportsComponent } from './seller/viewreports/viewreports.component';
import { AdminComponent } from './admin/admin/admin.component';
import { AddcategoryComponent } from './admin/addcategory/addcategory.component';
import { AddsubcategoryComponent } from './admin/addsubcategory/addsubcategory.component';
import { BblockUnblockComponent } from './admin/bblock-unblock/bblock-unblock.component';
import { DailyreportsComponent } from './admin/dailyreports/dailyreports.component';
import { SblockUnblockComponent } from './admin/sblock-unblock/sblock-unblock.component';
import { LoginComponent } from './account/login/login.component';
import { RegisterbuyerComponent } from './account/registerbuyer/registerbuyer.component';
import { RegistersellerComponent } from './account/registerseller/registerseller.component';
import { HomeComponent } from './account/home/home.component';
import { ViewcategoriesComponent } from './admin/viewcategories/viewcategories.component';
import { BuyproductComponent } from './buyer/buyproduct/buyproduct.component';
import { ViewsubcategoriesComponent } from './admin/viewsubcategories/viewsubcategories.component';
import { ContactComponent } from './seller/contact/contact.component';



const routes: Routes = [
  {path:'buyer',component:BuyerComponent,children:[
    //{path:'buyer',component:BuyerComponent},
    {path:'search',component:SearchComponent},
    {path:'viewcart',component:ViewcartComponent},
    {path:'purchase-history',component:PurchaseHistoryComponent},
    {path:'viewbuyerprofile',component:ViewbuyerprofileComponent},
    {path:'buyproduct',component:BuyproductComponent}
  ]},
  {path:'seller',component:SellerComponent,children:[
  //{path:'seller',component:SellerComponent},
  {path:'additems',component:AdditemsComponent},
  {path:'viewitems',component:ViewitemsComponent},
  {path:'viewreports',component:ViewreportsComponent},
  {path:'viewsellerprofile',component:ViewsellerprofileComponent},
  {path:'contact',component:ContactComponent}
  ]},
  {path:'admin',component:AdminComponent,children:[
   
    {path:'addcategory',component:AddcategoryComponent},
    {path:'addsubcategory',component:AddsubcategoryComponent},
    {path:'bblock-unblock',component:BblockUnblockComponent},
    {path:'dailyreports',component:DailyreportsComponent},
    {path:'sblock-unblock',component:SblockUnblockComponent},
    {path:'viewcategories',component:ViewcategoriesComponent},
    {path:'viewsubcategories',component:ViewsubcategoriesComponent}
  ]},
  {path:'home',component:HomeComponent,children:[
  {path:'login',component:LoginComponent},
  {path:'registerbuyer',component:RegisterbuyerComponent},
  {path:'registerseller',component:RegistersellerComponent}
  ]},
  {path:'',component:HomeComponent}


];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
