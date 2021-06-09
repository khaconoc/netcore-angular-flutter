import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NZ_I18N } from 'ng-zorro-antd/i18n';
import { en_US } from 'ng-zorro-antd/i18n';
import { registerLocaleData } from '@angular/common';
import en from '@angular/common/locales/en';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { IconsProviderModule } from './icons-provider.module';
import { NzLayoutModule } from 'ng-zorro-antd/layout';
import { NzMenuModule } from 'ng-zorro-antd/menu';
// import { NgZorroAntdModule, NZ_I18N, vi_VN, NzConfig, NZ_CONFIG } from 'ng-zorro-antd';
import { NzSpinModule } from 'ng-zorro-antd/spin';
import {NZ_CONFIG, NzConfig} from 'ng-zorro-antd/core/config';
import { NzNotificationModule } from 'ng-zorro-antd/notification';
import {NgZorroAntdModule} from "./_base/modules/ng-zorro-antd.module";
import {HeaderModule} from "./_share/templates/header/header.module";
import {MenuModule} from "./_share/templates/menu/menu.module";


registerLocaleData(en);
const ngZorroConfig: NzConfig = {
  message: {
    nzTop: 50,
    nzDuration: 5000
  },
  notification: {
    nzTop: 50,
    nzDuration: 5000
  },
  table: {
    nzBordered: true,
    nzHideOnSinglePage: true,
    nzSize: 'small'
  },
  tabs: {
    nzType: 'card'
  },
  modal: {
    nzMaskClosable: false
  }
};

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    IconsProviderModule,
    NzLayoutModule,
    NzMenuModule,
    NzSpinModule,
    NzNotificationModule,
    NgZorroAntdModule,
    HeaderModule,
    MenuModule,
  ],
  providers: [
    { provide: NZ_I18N, useValue: en_US },
    { provide: NZ_CONFIG, useValue: ngZorroConfig },
  ],
  bootstrap: [
    AppComponent
  ]
})
export class AppModule { }

