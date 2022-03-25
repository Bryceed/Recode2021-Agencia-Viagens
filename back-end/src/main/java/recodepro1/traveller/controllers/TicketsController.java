package recodepro1.traveller.controllers;

import java.net.URI;
import java.time.LocalDateTime;
import java.util.List;
import recodepro1.traveller.entities.Tickets;
import recodepro1.traveller.services.TicketsService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.servlet.support.ServletUriComponentsBuilder;

@RestController
@RequestMapping(value = "/tickets")
public class TicketsController {
    
    @Autowired
    private TicketsService ticketsService;
    
    @GetMapping
    public List<Tickets> findAll() {
        return ticketsService.findAll();
    }

    @CrossOrigin(origins = "http://localhost:3000/")
    @PostMapping("/create")
    public ResponseEntity<Tickets> save(@RequestBody Tickets ticket) {
        ticketsService.save(ticket);
        return ResponseEntity.ok().body(ticket);
    }

    @CrossOrigin(origins = "http://localhost:3000/")
    @PutMapping("/edit/{id}")
    public ResponseEntity<Tickets> edit(@PathVariable Long id, @RequestBody Tickets ticket) {
        var ticketkeep = ticketsService.edit(id, ticket);
        URI uri = ServletUriComponentsBuilder.fromCurrentRequest().path("/{id}").buildAndExpand(ticketkeep.getId()).toUri();

        return ResponseEntity.created(uri).body(ticketkeep);
    }

    @CrossOrigin(origins = "http://localhost:3000/")
    @DeleteMapping("/delete/{id}")
    public ResponseEntity<Void> delete(@PathVariable Long id) {
        ticketsService.delete(id);
        return ResponseEntity.noContent().build();
    }

}
