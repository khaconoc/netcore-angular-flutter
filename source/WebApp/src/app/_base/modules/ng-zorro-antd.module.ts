import {NgModule} from "@angular/core";

import { NzSpinModule } from 'ng-zorro-antd/spin';
import { NzButtonModule } from 'ng-zorro-antd/button';
import { NzBreadCrumbModule } from 'ng-zorro-antd/breadcrumb';
import { NzLayoutModule } from 'ng-zorro-antd/layout';
import { NzIconModule } from 'ng-zorro-antd/icon';
import { NzResultModule } from 'ng-zorro-antd/result';

@NgModule({
  imports: [

  ],
  exports: [
    NzSpinModule,
    NzButtonModule,
    NzBreadCrumbModule,
    NzLayoutModule,
    NzIconModule,
    NzResultModule
  ]
})
export class NgZorroAntdModule {}
