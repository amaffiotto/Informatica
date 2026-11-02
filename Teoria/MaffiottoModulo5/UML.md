# Diagrammi UML - Modulo 5

## Classe Studente

```text
+----------------------------------+
|             Studente             |
+----------------------------------+
| - _nome: string                  |
| - _cognome: string               |
| - _eta: int                      |
+----------------------------------+
| + Nome: string                   |
| + Cognome: string                |
| + Età: int                       |
| + Studente(n, c, e)              |
+----------------------------------+
```

## Gestione studenti

```text
+------------------------------------------------------+
|                       Program                        |
+------------------------------------------------------+
| studenti: List<Studente>                             |
| rubrica: Dictionary<int, Studente>                   |
| listaAttesa: Queue<string>                           |
| cancellazioni: Stack<string>                         |
| voti: Dictionary<int, int>                           |
+------------------------------------------------------+
| + AggiungiStudente(studenti, rubrica): void          |
| + RimuoviStudente(studenti, rubrica, ...): void      |
| + CercaStudente(rubrica): void                       |
| + OrdinaPerCognome(studenti): void                   |
| + FiltraPerEta(studenti): void                       |
| + AnnullaCancellazione(studenti, rubrica, ...): void |
+------------------------------------------------------+
```

## Gestione voti

```text
+------------------------------------------------+
|                    Program                     |
+------------------------------------------------+
| voti: Dictionary<int, int>                     |
+------------------------------------------------+
| + AggiungiAggiornaVoto(rubrica, voti): void    |
| + CalcolaMedia(voti): double                   |
| + TrovaIdVotoMassimo(voti): int                |
| + StampaStatisticheVoti(rubrica, voti): void   |
+------------------------------------------------+
```

La chiave dei due `Dictionary` rappresenta lo stesso ID: in `rubrica` permette di trovare lo studente, mentre in `voti` permette di trovare il suo voto.
