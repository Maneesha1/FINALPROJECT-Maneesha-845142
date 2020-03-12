import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import{ReactiveFormsModule,FormBuilder, FormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BuyerComponent } from 'src/app/buyer/buyer/buyer.component';
import { SellerComponent } from 'src/app/seller/seller/seller.component';
import { AdminComponent } from 'src/app/admin/admin/admin.component';
//import { BuyerLandingpageComponent } from './buyer/buyer-landingpage/buyer-landingpage.component';
import { SearchComponent } from './buyer/search/search.component';
import { ViewcartComponent } from './buyer/viewcart/viewcart.component';
import { PurchaseHistoryComponent } from './buyer/purchase-history/purchase-history.component';
import { ViewbuyerprofileComponent } from './buyer/viewbuyerprofile/viewbuyerprofile.component';
//import { SellerLandingpageComponent } from './seller/seller-landingpage/seller-landingpage.component';
import { AdditemsComponent } from './seller/additems/additems.component';
import { ViewitemsComponent } from './seller/viewitems/viewitems.component';
import { ViewreportsComponent } from './seller/viewreports/viewreports.component';
//import { AdminLandingpageComponent } from './admin/admin-landingpage/admin-landingpage.component';
import { BblockUnblockComponent } from './admin/bblock-unblock/bblock-unblock.component';
import { SblockUnblockComponent } from './admin/sblock-unblock/sblock-unblock.component';
import { AddcategoryComponent } from './admin/addcategory/addcategory.component';
import { AddsubcategoryComponent } from './admin/addsubcategory/addsubcategory.component';
import { DailyreportsComponent } from './admin/dailyreports/dailyreports.component';
import { LoginComponent } from './account/login/login.component';
import { RegisterbuyerComponent } from './account/registerbuyer/registerbuyer.component';
import { RegistersellerComponent } from './account/registerseller/registerseller.component';
import { HomeComponent } from './account/home/home.component';
import{HttpClient, HttpClientModule}from "@angular/common/http";
import { AccountService } from './services/account.service';
import{SellerService}from './services/seller.service';
import{AdminService} from'src/app/services/admin.service';
import { ViewcategoriesComponent } from './admin/viewcategories/viewcategories.component';
//import{ViewprofileComponent}from 'src/app/seller/viewprofile/viewprofile.component';
//import { EditcategoriesComponent } from './admin/editcategories/editcategories.component';
import { ViewsubcategoriesComponent } from './admin/viewsubcategories/viewsubcategories.component';
import { BuyerService } from './services/buyer.service';
import { BuyproductComponent } from './buyer/buyproduct/buyproduct.component';
//import { ViewbuyerprofileComponent } from './buyer/viewbuyerprofile/viewbuyerprofile.component';
import { ViewsellerprofileComponent } from './seller/viewsellerprofile/viewsellerprofile.component';
import { ContactComponent } from './seller/contact/contact.component';


@NgModule({
  declarations: [
    AppComponent,
    BuyerComponent,
    SellerComponent,
    AdminComponent,
    
    SearchComponent,
    ViewcartComponent,
    PurchaseHistoryComponent,
    ViewbuyerprofileComponent,
    
    AdditemsComponent,
    ViewitemsComponent,
    ViewreportsComponent,
    
    BblockUnblockComponent,
    SblockUnblockComponent,
    AddcategoryComponent,
    AddsubcategoryComponent,
    DailyreportsComponent,
    LoginComponent,
    RegisterbuyerComponent,
    RegistersellerComponent,
    HomeComponent,
    ViewcategoriesComponent,
    
    //EditcategoriesComponent,
    ViewsubcategoriesComponent,
    
    BuyproductComponent,
    
    ViewbuyerprofileComponent,
    
    ViewsellerprofileComponent,
    
    ContactComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [AccountService,SellerService,AdminService,BuyerService],
  bootstrap: [AppComponent]
})
export class AppModule { }
