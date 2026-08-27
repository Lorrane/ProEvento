import { Component } from '@angular/core';
import { NgForOf } from "../../../node_modules/@angular/common/types/_common_module-chunk";

@Component({
  selector: 'app-eventos',
  styleUrl: './eventos.scss',
  templateUrl: './eventos.html',
})
export class Eventos {

  public eventos: any = [
    {
      tema: 'Angular',
      local: 'São Paulo',
      dataEvento: '2024-06-20',
      qtdPessoas: 250
    },
    {
      tema: 'Dot Net',
      local: 'Rio de Janeiro',
      dataEvento: '2026-08-20',
      qtdPessoas: 250
    }
  ]
}
