import { Injectable } from '@angular/core';
import{HttpClient,HttpHeaders}from '@angular/common/http';
import{Observable} from 'Rxjs';
import{Items}from 'src/app/Models/items';
import { Seller } from '../Models/seller';
import { Category } from '../Models/category';
import { Subcategory } from '../Models/subcategory';
const Requestheaders={headers:new HttpHeaders({
  'Content-Type':'application/json',
  'Authorization': 'Bearer '+localStorage.getItem('token')

})}


@Injectable({
  providedIn: 'root'
})
export class SellerService {
  url:string='http://localhost:51402/Item/';
  url1:string='http://localhost:51402/Seller/'

  constructor(private http:HttpClient) { }
  public AddItem(item:Items):Observable<any>
  {
    return this.http.post<any>(this.url+'AddItem',JSON.stringify(item),Requestheaders);
  }
  public ViewItems():Observable<Items[]>
  {
    return this.http.get<Items[]>(this.url+'ViewItems',Requestheaders);
  }
  public GetCategories():Observable<Category[]>
  {
    return this.http.get<Category[]>(this.url+'GetCategories',Requestheaders);
  }
  public GetSubCategories( catid:string):Observable<Subcategory[]>
  {
    return this.http.get<Subcategory[]>(this.url+'GetSubCategories/'+catid);
  }
   public DeleteItem(itemid:string):Observable<any>
  {
   return this.http.delete<any>(this.url+'DeleteItem/'+itemid,Requestheaders);
  }
  public UpdateItem(item:Items):Observable<any>
  {
    return this.http.put<any>(this.url+'UpdateItem/',JSON.stringify(item),Requestheaders);
  }
  public GetItem(id:string) : Observable<Items>
  {
    return this.http.get<Items>(this.url+'GetItem/'+id,Requestheaders)
  }
  public EditProfile(seller:Seller):Observable<any>
  {
    return this.http.put<any>(this.url1+'EditProfile',JSON.stringify(seller),Requestheaders);
  }
  public GetProfile(Sid:string):Observable<Seller>
  {
return this.http.get<Seller>(this.url1+'GetProfile/'+Sid,Requestheaders);
  }
  public ViewProfile(id:string) : Observable<Seller>
  {
    return this.http.get<Seller>(this.url1+'ViewProfile/'+id,Requestheaders)
  }



}
