
using GameProjectDemo.Concrate;
using GameProjectDemo.Entities;

GamerManager gamerManager = new GamerManager( new UserValidationManager());

gamerManager.Add(new Gamer
{
    Id = 1,
    BirthYear = 2002,
    FirstName = "Samet",
    LastName = "Kotu",
    IdentityNumber = 123456

});

gamerManager.Sale(new Gamer
{
    Id = 1,
    BirthYear = 2002,
    FirstName = "Samet",
    LastName = "Kotu",
    IdentityNumber = 123456

});

CampaignManager campaignManager = new CampaignManager();
campaignManager.Create( new Campaign
{
    Ad = "Kampanya 1",
    Baslangıc = "Pazartesi",
    Bitis = "Cuma"
});