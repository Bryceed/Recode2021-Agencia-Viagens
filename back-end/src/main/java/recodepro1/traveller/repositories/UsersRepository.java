package recodepro1.traveller.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import recodepro1.traveller.entities.Users;

@Repository
public interface UsersRepository extends JpaRepository<Users, Long> {
    
}
