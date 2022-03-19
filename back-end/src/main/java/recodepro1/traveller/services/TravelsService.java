package recodepro1.traveller.services;

import java.util.List;
import java.util.Optional;

import org.apache.tomcat.jni.Status;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.dao.DataIntegrityViolationException;
import org.springframework.dao.EmptyResultDataAccessException;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import recodepro1.traveller.entities.Travels;
import recodepro1.traveller.entities.Travels;
import recodepro1.traveller.repositories.TravelsRepository;
import recodepro1.traveller.services.exceptions.DatabaseException;
import recodepro1.traveller.services.exceptions.ResourceNotFoundException;

@Service
public class TravelsService {

    @Autowired
    private TravelsRepository travelsRepository;

    @Transactional(readOnly = true)
    public List<Travels> findAll() {
        List<Travels> travels = travelsRepository.findAll();
        return travels;
    }

    @Transactional(readOnly = true)
    public Travels findById(Long id) {
        Optional<Travels> travel = travelsRepository.findById(id);
        return travel.orElseThrow(() -> new RuntimeException("Travel by the ID nº"+id+" was not found"));
    }

    @Transactional
    public void save(Travels travel) {
        travelsRepository.save(travel);
    }

    @Transactional
    public Travels edit(Long id, Travels usuario) {
        Travels travelToEdit = travelsRepository.getOne(id); 

        travelToEdit.setDestination(usuario.getDestination());
        travelToEdit.setImgCode(usuario.getImgCode());
        travelToEdit.setPrice(usuario.getPrice());
        travelToEdit.setIsActive(usuario.getIsActive());
        travelToEdit.setIsPromotional(usuario.getIsPromotional());

        travelToEdit = travelsRepository.save(travelToEdit);

        return new Travels();
    }

    @Transactional
    public void delete(Long id) {
        try {
            travelsRepository.deleteById(id);
        } catch (EmptyResultDataAccessException e) {
            throw new ResourceNotFoundException("Travel ID: \"" + id + "\" was not found. Probably it was deleted or never existed.");
        } catch (DataIntegrityViolationException e) {
            throw new DatabaseException("Integrity violation. Please, check if the Travel ID: \"" + id + "\" was not used in any other table.");
        }
    }
}
