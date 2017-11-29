import java.util.List;

import org.junit.After;
import org.junit.Assert;
import org.junit.Before;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

public class TesteRegrasCadastro {

	private WebDriver driver;
	private DSL dsl;
	private CampoTreinamentoPage page;
	private String nome;
	private String sobrenome;
	private String sexo;
	private List<String> comidas;

	@Before
	public void inicializa() {
		driver = new ChromeDriver();
		driver.manage().window().maximize();
		driver.get("file:///" + System.getProperty("user.dir") + "/src/main/resources/componentes.html");
		dsl = new DSL(driver);
		page = new CampoTreinamentoPage(driver);
	}

	@After
	public void finaliza() {
		driver.quit();
	}

	public void deveValidarRegras() {
		page.setNome(nome);
		page.setSobrenome(sobrenome);
		if (sexo.equals("Masculino")) {
			page.setSexoMasculino();
		} else {
			page.setSexoFeminino();
		}
		// PAROU AQUI
		// 30/11/2017
		if (comidas.contains("Carne"))
			page.setComidaCarne();
		if (comidas.contains("Pizza"))
			page.setComidaPizza();
		if (comidas.contains("Vegetariano"))
			page.setComidaVegetariano();

		page.setComidaCarne();
		page.setEsporte("Corrida", "O que eh esporte?");
		page.cadastrar();

		Assert.assertEquals("Voce faz esporte ou nao?", dsl.alertaObterTextoEAceita());
	}

}