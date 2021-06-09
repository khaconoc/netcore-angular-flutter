import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ExampleControlComponent } from './example-control.component';
import { ExampleControlRouting } from "./example-control.routing";



@NgModule({
  declarations: [
    ExampleControlComponent
  ],
  imports: [
    CommonModule,
    ExampleControlRouting
  ]
})
export class ExampleControlModule { }
