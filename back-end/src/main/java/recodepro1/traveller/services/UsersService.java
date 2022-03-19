package recodepro1.traveller.services;

import java.util.List;
import java.util.Optional;

import org.apache.tomcat.jni.Status;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.dao.DataIntegrityViolationException;
import org.springframework.dao.EmptyResultDataAccessException;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import recodepro1.traveller.entities.Users;
import recodepro1.traveller.repositories.UsersRepository;
import recodepro1.traveller.services.exceptions.DatabaseException;
import recodepro1.traveller.services.exceptions.ResourceNotFoundException;

@Service
public class UsersService {
    
    @Autowired
    private UsersRepository usersRepository;

    @Transactional(readOnly = true)
    public List<Users> findAll() {
        List<Users> users = usersRepository.findAll();
        return users;
    }

    @Transactional(readOnly = true)
    public Users findById(Long id) {
        Optional<Users> user = usersRepository.findById(id);
        return user.orElseThrow(() -> new RuntimeException("User by the ID nº"+id+" was not found"));
    }

    @Transactional
    public void save(Users user) {
        usersRepository.save(user);
    }

    @Transactional
    public Users edit(Long id, Users usuario) {
        Users userToEdit = usersRepository.getOne(id); 

        userToEdit.setName(usuario.getName());
        userToEdit.setNick(usuario.getNick());

        userToEdit = usersRepository.save(userToEdit);

        return new Users();
    }

    @Transactional
    public void delete(Long id) {
        try {
            usersRepository.deleteById(id);
        } catch (EmptyResultDataAccessException e) {
            throw new ResourceNotFoundException("Id not found: " + id);
        } catch (DataIntegrityViolationException e) {
            throw new DatabaseException("Integrity violation");
        }
    }


}
