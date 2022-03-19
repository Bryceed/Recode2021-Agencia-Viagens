package recodepro1.traveller.controllers;

import java.net.URI;
import java.time.LocalDateTime;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.servlet.support.ServletUriComponentsBuilder;

import lombok.extern.log4j.Log4j2;
import recodepro1.traveller.entities.Users;
import recodepro1.traveller.services.UsersService;
import recodepro1.traveller.util.DateUtil;

@RestController // work with @ResponseBody and string (ideal for APIs)
@RequestMapping(value = "/users")
public class UsersController {
    
    @Autowired
    private UsersService usersService;
    @Autowired
    private DateUtil dateUtil; //@autowired = new DateUtil()
    
    @GetMapping
    public List<Users> findAll() {
        return usersService.findAll();
    }

    @PostMapping("/create")
    public ResponseEntity<Users> save(@RequestBody Users user) {
        usersService.save(user);
        return ResponseEntity.ok().body(user);
    }

    @PutMapping("/edit/{id}")
    public ResponseEntity<Users> edit(@PathVariable Long id, @RequestBody Users usuario) {
        usuario = usersService.edit(id, usuario);
        URI uri = ServletUriComponentsBuilder.fromCurrentRequest().path("/{id}").buildAndExpand(usuario.getId()).toUri();

        return ResponseEntity.created(uri).body(usuario);
    }

    @DeleteMapping("/delete/{id}")
    public ResponseEntity<Void> delete(@PathVariable Long id) {
        usersService.delete(id);
        return ResponseEntity.noContent().build();
    }

}
