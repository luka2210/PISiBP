// File:    ZahtevZaServisiranje.cs
// Author:  lukam
// Created: 08 September 2022 17:02:11
// Purpose: Definition of Class ZahtevZaServisiranje

using System;

public class ZahtevZaServisiranje
{
   private int idZahteva;
   private string opisProblema;
   private DateTime datumPodnosenjaZahteva;
   private bool otklonjenProblem;
   private bool zavrsenoServisiranje;
   private DateTime datumServisiranja;
   
   public int IdZahteva
   {
      get
      {
         return idZahteva;
      }
      set
      {
         this.idZahteva = value;
      }
   }
   
   public string OpisProblema
   {
      get
      {
         return opisProblema;
      }
      set
      {
         this.opisProblema = value;
      }
   }
   
   public DateTime DatumPodnosenjaZahteva
   {
      get
      {
         return datumPodnosenjaZahteva;
      }
      set
      {
         this.datumPodnosenjaZahteva = value;
      }
   }
   
   public bool OtklonjenProblem
   {
      get
      {
         return otklonjenProblem;
      }
      set
      {
         this.otklonjenProblem = value;
      }
   }
   
   public bool ZavrsenoServisiranje
   {
      get
      {
         return zavrsenoServisiranje;
      }
      set
      {
         this.zavrsenoServisiranje = value;
      }
   }
   
   public DateTime DatumServisiranja
   {
      get
      {
         return datumServisiranja;
      }
      set
      {
         this.datumServisiranja = value;
      }
   }

}