# DatabaseTypeErrorException

### DBT1
    Unable to get a database type for propertie named 'name' of type 'type'. Did you used [NotGenerateColumn] attribute ?"
- Si vous avez une cette erreur la c'est que vous avez essayé de convertir un type d'une propriété qui n'existe pas dans la base de données.
    ##### Correction
    Lors de la création de votre classe il vous suffit d'ajouter l'attribut personnalisé [NotGenerateColumn]. Pourquoi ? La plupart du temps cette erreur vous arrivera quand vous essayerez d'insérer un objet que vous avez créée. Hors, on ne va pas insérer directement cet objet dans la base.
    Pour toutes les propriétées que vous ne voulez pas en base rajouter l'attribut [NotGenerateColumn].
    
##### Exemple
Exemple typique de l'erreur qui pourrait vous arriver. Dans ce cas la solution au problème est de mettre [NotGenerateColumn] au dessus de "public Contrat contrat {get; set;}". Il ne tentera donc pas de convertir le type Contrat en type de base de données a l'éxécution de la méthode dans Main.cs 
###### Client.cs
```csharp
public class Client {
        public int id_client { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public Contrat contrat { get; set; }
}
```
###### Main.cs
```csharp
noxORM.src.core.definitions.Model model = ModelConverter.Instance.ConvertToModel<Client>();
```