// Created via ng g service services/pet.service
// Which makes it Dependency Injectable automatically
//       and creates an empty constructor
import { Injectable } from '@angular/core';
import { PetInfo } from '../interfaces/pet-info';

@Injectable({
  providedIn: 'root'
})
// The class of the service (aka module) contains the data and the functions to manage the data 
export class PetService {

// Typically  data is kept in an array inside the service 
// and is decribed by an interface

  petData : PetInfo[] = []

  constructor(){
    this.petData.push({name: 'Casper', type: 'Dog', gender: 'Male'})
    this.petData.push({name: 'Oats', type: 'Cat', gender: 'Female'})
    this.petData.push({name: 'Koda', type: 'Dog', gender: 'Male'})
    this.petData.push({name: 'Lilo', type: 'Rabbit', gender: 'Female'})
    this.petData.push({name: 'Nacho Bell Grande', type: 'Cat', gender: 'Male'})
  }
// Provide a function to return the array of data
getPetData() : PetInfo[]{
  return this.petData;
}

}
