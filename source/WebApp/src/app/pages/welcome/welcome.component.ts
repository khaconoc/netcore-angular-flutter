import { Component, OnInit } from '@angular/core';
import {MessageService} from "../../_base/services/message.service";
import {NzNotificationService} from "ng-zorro-antd/notification";

@Component({
  selector: 'app-welcome',
  templateUrl: './welcome.component.html',
  styleUrls: ['./welcome.component.scss']
})
export class WelcomeComponent implements OnInit {

  constructor(
    private messageService : MessageService,
    private notification: NzNotificationService
  ) { }

  ngOnInit() {
  }

  showLog() {
    this.notification
      .blank(
        'Notification Title',
        'This is the content of the notification. This is the content of the notification. This is the content of the notification.'
      )
      .onClick.subscribe(() => {
      console.log('notification clicked!');
    });
    this.messageService.showMessageSuccess('ahhhhhhiihi');
  }
}
