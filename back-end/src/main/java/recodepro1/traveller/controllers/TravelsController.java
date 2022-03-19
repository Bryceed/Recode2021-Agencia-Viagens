package recodepro1.traveller.controllers;

import java.net.URI;
import java.time.LocalDateTime;
import java.util.List;
import recodepro1.traveller.entities.Travels;
import recodepro1.traveller.services.TravelsService;
import recodepro1.traveller.util.DateUtil;
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

@RestController
@RequestMapping(value = "/travels")
public class TravelsController {
    
    @Autowired
    private TravelsService travelsService;
    
    @GetMapping
    public List<Travels> findAll() {
        return travelsService.findAll();
    }

    @PostMapping("/create")
    public ResponseEntity<Travels> save(@RequestBody Travels travel) {
        travelsService.save(travel);
        return ResponseEntity.ok().body(travel);
    }

    @PutMapping("/edit/{id}")
    public ResponseEntity<Travels> edit(@PathVariable Long id, @RequestBody Travels travel) {
        var travelkeep = travelsService.edit(id, travel);
        URI uri = ServletUriComponentsBuilder.fromCurrentRequest().path("/{id}").buildAndExpand(travelkeep.getId()).toUri();

        return ResponseEntity.created(uri).body(travelkeep);
    }

    @DeleteMapping("/delete/{id}")
    public ResponseEntity<Void> delete(@PathVariable Long id) {
        travelsService.delete(id);
        return ResponseEntity.noContent().build();
    }

}
