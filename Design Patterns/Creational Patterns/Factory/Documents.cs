namespace Design_Patterns.Creational_Patterns.Factory;

public abstract class Document
{
    private List<Page> _pages = new();
    public List<Page> Pages => _pages;
    
    protected Document() => CreatePages();
    
    protected abstract void CreatePages();
}

public class Resume : Document
{
    // Factory Method implementation
    protected override void CreatePages()
    {
        Pages.Add(new SkillsPage());
        Pages.Add(new EducationPage());
        Pages.Add(new ExperiencePage());
    }
}

public class Report : Document
{
    // Factory Method implementation
    protected override void CreatePages()
    {
        Pages.Add(new IntroductionPage());
        Pages.Add(new ResultsPage());
        Pages.Add(new ConclusionPage());
        Pages.Add(new SummaryPage());
        Pages.Add(new BibliographyPage());
    }
}
