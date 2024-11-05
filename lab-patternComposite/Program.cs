using lab_patternComposite;

Section root = new Section("Главная");
root.Add(new Page("О нас"));
root.Add(new Page("Документы"));
root.Add(new Page("Новости"));
root.Add(new Page("Контакты"));

Section products = new Section("Машины");
products.Add(new Page("Mersedes"));
products.Add(new Page("Porshe"));
products.Add(new Page("BMW"));

root.Add(products);

Section services = new Section("Услуги");
services.Add(new Page("Покраска"));
services.Add(new Page("Шиномонтаж"));
services.Add(new Page("Автомойка"));

root.Add(services);

root.Display(1);