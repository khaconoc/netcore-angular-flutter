import {Injectable} from "@angular/core";

@Injectable({
  providedIn: 'root'
})
export class MessageService {
  public showMessageSuccess(message: string): void {
    console.log(message);
  }
}
