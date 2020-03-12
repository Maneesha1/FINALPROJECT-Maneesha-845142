import { Injectable } from '@angular/core';
import{HttpClient,HttpHeaders}from '@angular/common/http';
import{Observable} from 'Rxjs';
import{Buyer}from'../Models/buyer';
import { Seller } from '../Models/seller';

const Requestheaders={headers:new HttpHeaders({
  'Content-Type':'application/json',
  'Authorization': 'Bearer '+localStorage.getItem('token')
  

})}



@Injectable({
  providedIn: 'root'
})
export class AccountService {
  url:string='http://localhost:51402/Account/';

  constructor(private http:HttpClient) { }
  public BuyerRegister(buyer:Buyer):Observable<any>
  {
    return this.http.post<any>(this.url+'BuyerRegister',JSON.stringify(buyer),Requestheaders);
  }
  public SellerRegister(seller:Seller):Observable<any>
  {
    return this.http.post<any>(this.url+'SellerRegister',JSON.stringify(seller),Requestheaders);
  }
  public BuyerLogin(username:string,password:string):Observable<any>
  {
    return this.http.get<any>(this.url+'BuyerLogin/'+username+'/'+password,Requestheaders)
  }
  public SellerLogin(username:string,password:string):Observable<any>
  {
    return this.http.get<any>(this.url+'SellerLogin/'+username+'/'+password,Requestheaders)
  }

}
