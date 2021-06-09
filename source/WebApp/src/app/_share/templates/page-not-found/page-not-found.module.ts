import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PageNotFoundComponent } from './page-not-found.component';
import {PageNotFoundRouters} from "./page-not-found.routing";
import {NgZorroAntdModule} from "../../../_base/modules/ng-zorro-antd.module";




@NgModule({
  declarations: [
    PageNotFoundComponent,
  ],
  imports: [
    CommonModule,
    // NzResultModule,
    NgZorroAntdModule,
    PageNotFoundRouters
  ]
})
export class PageNotFoundModule { }
