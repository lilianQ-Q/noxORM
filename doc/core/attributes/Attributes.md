# Attributes
Pour utiliser la librairie n'oubliez pas la directive suivante au début de votre fichier
``` using noxOrm.src.core.attributes; ```
Ce dossier contient toutes les classes d'attributs. Celles-ci définissent les différents éléments que l'on va retrouver dans une base de données.
- BaseAttributes.cs : Ce fichier est vide, il sert de classe "relais" et de classe mère pour toutes les autres suivante. Il implémente "System.Attribute" qui nous permet de définir des attributs customisés. 
### Exemple
Nous avons une classe qui s'appelle Biloute, mais dans la base de données la table s'apelle Bilouteeee on va pouvoir utiliser cette classe de cette manière : 
``` 
    [TableName("Bilouteeee")]
    class Biloute
    {
    }
```

#### ColumnName
- ColumnName.cs : Cette classe permet de créer un attribut personnalisé sur un champ d'une autre classe qui définit un nom de colonne dans la base de donnée.
    ##### ColumnName exemple
```

```

#### ColumnType
- ColumnType.cs : Cette classe permet de créer un attribut personnalisé sur un champ d'une autre classe, ell définit un type de donnée dans la base de données. On va déclarer de quel type il s'agit, la taille de la valeure et si celle-ci peut être nulle.
    #### ColumnType Exemple
```

```

#### ForeignKey
- ForeignKey.cs : Cette classe permet de créer un attribut personnalisé sur un champ d'une autre classe, elle définit un nom de clé étrangère et ses références.
    ##### ForeignKey Exemple
``` 
    public class Test
    {
        [ForeignKey("Le nom de l'id dans la base de données", "Le nom de la contrainte", "La table a laquelle on fait référence", "L'id auquel on fait référence")]
        public string IdEtranger { get; set; }
    }
```

#### PrimaryKey
- PrimaryKey.cs : Cette classe permet de créer un attribut personnalisé sur un champ d'une autre classe, elle définit un nom de clé primaire. 
    ##### PrimaryKey Exemple
``` 
public class Test
    {
        [PrimaryKey("id_client","pk_Clients1")]
        public string IdClient { get; set; }
    } 
```

#### TabmeName
- TableName : Cette classe permet de créer un attribut personnalisé sur un champ d'une autre classe, elle définit un nom de table. (Comme vu dans l'exemple plus haut...)
    ##### TableName Exemple
```

```