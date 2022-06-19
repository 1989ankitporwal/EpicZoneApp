import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

declare const CryptoJS: any;

@Injectable({
  providedIn: 'root'
})
export class UtilService {

  constructor() { }
  Encrypt(data: any): any{
    let jsondata = JSON.stringify(data);
    return CryptoJS.AES.encrypt(jsondata, environment.encKey);
  }

  Decrypt(encData: any):any{
      var bytes = CryptoJS.AES.decrypt(encData.toString(), environment.encKey);
      var data = bytes.toString(CryptoJS.enc.Utf8);
      return JSON.parse(data);
  }
}
