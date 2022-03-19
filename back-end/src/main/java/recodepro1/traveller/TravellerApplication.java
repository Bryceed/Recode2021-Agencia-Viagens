package recodepro1.traveller;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.EnableAutoConfiguration;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.ComponentScan;

@EnableAutoConfiguration
@SpringBootApplication
// @ComponentScan(basePackages = "recodepro1.traveller")
public class TravellerApplication {

	public static void main(String[] args) {
		SpringApplication.run(TravellerApplication.class, args);
	}

}
