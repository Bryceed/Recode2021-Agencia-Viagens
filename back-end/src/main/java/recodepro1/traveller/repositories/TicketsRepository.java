package recodepro1.traveller.repositories;

import org.springframework.data.jpa.repository.JpaRepository;

import recodepro1.traveller.entities.Tickets;

public interface TicketsRepository extends JpaRepository<Tickets, Long> {

    
}
