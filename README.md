## Endepunkt:

Get https://wine-lottery-gmg3ducqewc2a2db.westeurope-01.azurewebsites.net/api/ticket

Get https://wine-lottery-gmg3ducqewc2a2db.westeurope-01.azurewebsites.net/api/ticket/available

Post https://wine-lottery-gmg3ducqewc2a2db.westeurope-01.azurewebsites.net/api/ticket/purchase
```
Body for /purchase:
{
    "ticketId": 1,
    "buyerName": "Test Testesen"
}
```
Post https://wine-lottery-gmg3ducqewc2a2db.westeurope-01.azurewebsites.net/api/ticket/create?ticketId={id}

## Hva jeg ville gjort videre for å ferdigstille applikasjonen
- brukerverifisering med for eksempel azure konto
- kjøp av flere lodd på en gang
- tilbakestille lodd
- betaling
- database
- modell for vin
- endepunkt for trekning av vin; sjekke hvor mye en vin koster, begynne med billigste vin til det er tomt, lagrer vinnerlodd med navn på vinner og vin
- vise vinnere
- varsle vinnere
- lage frontend
