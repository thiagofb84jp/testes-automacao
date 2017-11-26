import org.junit.After;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

public class TesteGoogle {

	private WebDriver driver;
	
	@Before
	public void inicializa() {
		driver = new ChromeDriver();
		driver.manage().window().maximize();
		driver.get("http://www.google.com");		
	}
	
	@After
	public void finaliza() {
		driver.quit();
	}
	
	@Test
	public void verificarTituloPagina() {		
		//System.setProperty("webdriver.geckodriver", "inserir_local_onde_o_path_foi_descompactado/geckodriver.exe");	
//		WebDriver driver = new FirefoxDriver();
		Assert.assertEquals("Google", driver.getTitle());
	}	
}