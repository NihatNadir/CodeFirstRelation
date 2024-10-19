# CodeFirstRelation ENG || TR

## Created using Entity Framework Core with Code First approach.
#### Entities and variables created for the database table
###### User Table:
- Id: int, primary key and auto-incremented.
- Username: string, the user's username.
- Email: string, the user's email address.
###### Post Table:
- Id: int, primary key and auto-incremented.
- Title: string, the title of the post.
- Content: string, the content of the post.
- UserId: int, the author of the post (user’s ID).
  
#### A user can have multiple posts, but each post belongs to only one user.
- The name of our context class should be PatikaSecondDbContext.
- The database name should be PatikaCodeFirstDb2.
- In the database, the tables should be Users and Posts.



## Entity Framework Core kullanarak Code First yaklaşımını kullanarak oluşturdum.
#### Veritabanı tablosu için oluşturulan entity ve değişkenler
##### User Tablosu:
- Id: int, birincil anahtar ve otomatik artan.
- Username: string, kullanıcının kullanıcı adı.
- Email: string, kullanıcının e-posta adresi.

##### Post Tablosu:
- Id: int, birincil anahtar ve otomatik artan.
- Title: string, gönderinin başlığı.
- Content: string, gönderinin içeriği.
- UserId: int, gönderinin yazarı (kullanıcının kimliği).

#### Bir kullanıcının birden fazla gönderisi olabilir, ancak her gönderi yalnızca bir kullanıcıya ait olacak.
- Context sınıfımızın ismi PatikaSecondDbContext olsun.
- Veritabanı ismi PatikaCodeFirstDb2 olsun.
- Veritabanında tablolar Users ve Posts olsun.
