public class Portfolio {
    public string name;
    //Кол-во страниц
    public int pagesAmount;

    public string GetFullName() {
        return name + " " + pagesAmount;
    }
}