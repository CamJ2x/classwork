import { Component } from '@angular/core';
import { GamblerDataLayout } from '../../interfaces/GamblerDataLayout';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-home-page',
  imports: [CommonModule],
  templateUrl: './home-page.html',
  styleUrl: './home-page.css'
})
export class HomePage {
  theGamblers : GamblerDataLayout [] = [
  {id : 1, address : "Detroit",name : "Madonna",birthDate : "01/02/1963", salary : 1000000},
  {id : 11, address : "Tupelo",name : "Elvis",birthDate : "09/02/1943", salary : 9868000},
  {id : 99, address : "Corleone",name : "Vito",birthDate : "12/24/1999", salary : 58000}
  
  ]

}
