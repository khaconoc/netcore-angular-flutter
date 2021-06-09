import {NgModule} from '@angular/core';

import {WelcomeRoutingModule} from './welcome-routing.module';

import {WelcomeComponent} from './welcome.component';
import {NgZorroAntdModule} from "../../_base/modules/ng-zorro-antd.module";

@NgModule({
  imports: [
    WelcomeRoutingModule,
    NgZorroAntdModule
  ],
  declarations: [
    WelcomeComponent
  ],
  exports: [
    WelcomeComponent
  ]
})
export class WelcomeModule {
}
