import { Injectable } from '@angular/core';
import{HttpClient,HttpHeaders} from '@angular/common/http'
import{Observable}from 'Rxjs';
import{Buyer}from'../Models/buyer';
import { Items } from '../Models/items';
import{ Transactionhistory} from 'src/app/Models/transactionhistory';
import { Cart } from '../Models/cart';
const Requestheaders={headers:new HttpHeaders({
  'Content-Type':'application/json',
  'Authorization': 'Bearer '+localStorage.getItem('token')
})}


@Injectable({
  providedIn: 'root'
})
export class BuyerService {
  EditCategories() {
    throw new Error("Method not implemented.");
  }
  
url:string='http://localhost:51402/Buyer/';

  constructor(private http:HttpClient) { }
  // public BuyerRegister(buyer:Buyer):Observable<any>
  // {
  //   return this.http.post<any>(this.url+'regbuyer',JSON.stringify(buyer),Requestheaders);
  // }
  // public ViewProfile():Observable<any>
  // {
  //   return this.http.get<any>(this.url+'ViewProfile',Requestheaders);
  // }
  // public EditProfile():Observable<any>
  // {
  //   return this.http.post<any>(this.url+'EditProfile',Requestheaders);
  // }
  public SearchItems(name:string) : Observable<Items[]>
  {
    return this.http.get<Items[]>(this.url+'SearchItems/'+name,Requestheaders)
  }
  public BuyItem(transactionhistory:Transactionhistory):Observable<Transactionhistory>
  {
  return this.http.post<Transactionhistory>(this.url+'BuyItem/',transactionhistory,Requestheaders);
  }
  public EditProfile(buyer:Buyer):Observable<any>
  {
    return this.http.put<any>(this.url+'EditProfile',JSON.stringify(buyer),Requestheaders);
  }
  public ViewProfile(buyerId:string):Observable<any>
  {
    return this.http.get<Buyer>(this.url+'ViewProfile/'+buyerId,Requestheaders);
  }
 
   public Addtocart(cartobj:Cart) :Observable<Cart>
  {
    return this.http.post<Cart>(this.url+'Addtocart',cartobj,Requestheaders);
   }

   public Deletefromcart(cartid:string) :Observable<Cart>
  {
    return this.http.delete<Cart>(this.url+'Deletefromcart/'+cartid,Requestheaders);
   }
   public ViewCart(buyerid:string) :Observable<Cart>
   {
     return this.http.get<Cart>(this.url+'ViewCart/'+buyerid,Requestheaders);
    }
    
     public PurchaseHistory(buyerid:string) :Observable<Transactionhistory>
   {
     return this.http.get<Transactionhistory>(this.url+'PurchaseHistory/'+buyerid,Requestheaders);
    }
 

}
