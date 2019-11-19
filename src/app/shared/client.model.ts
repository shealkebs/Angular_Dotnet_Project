export class Client{

      ClientID? : number
      FirstName:String 
      LastName:String 
      BirthDate :Date
      Address : address[];


}

export interface address{

      AddressId: number;
      ClientLocation: string;
      ClientID:number;
  
  }
