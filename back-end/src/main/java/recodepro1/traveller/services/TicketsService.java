package recodepro1.traveller.services;

import java.util.List;
import java.util.Optional;

import org.apache.tomcat.jni.Status;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.dao.DataIntegrityViolationException;
import org.springframework.dao.EmptyResultDataAccessException;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import recodepro1.traveller.entities.Tickets;
import recodepro1.traveller.repositories.TicketsRepository;
import recodepro1.traveller.services.exceptions.DatabaseException;
import recodepro1.traveller.services.exceptions.ResourceNotFoundException;

@Service
public class TicketsService {
    @Autowired
    private TicketsRepository ticketsRepository;

    @Transactional(readOnly = true)
    public List<Tickets> findAll() {
        List<Tickets> tickets = ticketsRepository.findAll();
        return tickets;
    }

    @Transactional(readOnly = true)
    public Tickets findById(Long id) {
        Optional<Tickets> ticket = ticketsRepository.findById(id);
        return ticket.orElseThrow(() -> new RuntimeException("Ticket by the ID nº"+id+" was not found"));
    }

    @Transactional
    public void save(Tickets ticket) {
        ticketsRepository.save(ticket);
    }

    @Transactional
    public Tickets edit(Long id, Tickets usuario) {
        Tickets ticketToEdit = ticketsRepository.getOne(id); 

        ticketToEdit.setName(usuario.getName());
        ticketToEdit.setEmail(usuario.getEmail());
        ticketToEdit.setPhone(usuario.getPhone());
        ticketToEdit.setContactTitle(usuario.getContactTitle());
        ticketToEdit.setContactDescription(usuario.getContactDescription());
        ticketToEdit.setIsActive(usuario.getIsActive());

        ticketToEdit = ticketsRepository.save(ticketToEdit);

        return new Tickets();
    }

    @Transactional
    public void delete(Long id) {
        try {
            ticketsRepository.deleteById(id);
        } catch (EmptyResultDataAccessException e) {
            throw new ResourceNotFoundException("Ticket ID: \"" + id + "\" was not found. Probably it was deleted or never existed.");
        } catch (DataIntegrityViolationException e) {
            throw new DatabaseException("Integrity violation. Please, check if the Ticket ID: \"" + id + "\" was not used in any other table.");
        }
    }
}
