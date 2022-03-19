package recodepro1.traveller.entities;
import java.util.Objects;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

import org.springframework.beans.factory.annotation.Autowired;

import recodepro1.traveller.util.DateUtil;

@Entity
public class Travels {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    @Column(nullable = false)
    private String destination;
    @Column(nullable = false)
    private String imgCode;
    @Column(nullable = false)
    private Double price;
    @Column(nullable = false)
    private Boolean isActive;
    @Column(nullable = false)
    private Boolean isPromotional;
    @Column(nullable = true)
    private String promotionalPrice;

    public Travels() {
    }

    public Travels(String destination, String imgCode, Double price, Boolean isActive, Boolean isPromotional,
            String promotionalPrice) {
        this.destination = destination;
        this.imgCode = imgCode;
        this.price = price;
        this.isActive = isActive;
        this.isPromotional = isPromotional;
        this.promotionalPrice = promotionalPrice;
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getDestination() {
        return destination;
    }

    public void setDestination(String destination) {
        this.destination = destination;
    }

    public String getImgCode() {
        return imgCode;
    }

    public void setImgCode(String imgCode) {
        this.imgCode = imgCode;
    }

    public Double getPrice() {
        return price;
    }

    public void setPrice(Double price) {
        this.price = price;
    }

    public Boolean getIsActive() {
        return isActive;
    }

    public void setIsActive(Boolean isActive) {
        this.isActive = isActive;
    }

    public Boolean getIsPromotional() {
        return isPromotional;
    }

    public void setIsPromotional(Boolean isPromotional) {
        this.isPromotional = isPromotional;
    }

    public String getPromotionalPrice() {
        return promotionalPrice;
    }

    public void setPromotionalPrice(String promotionalPrice) {
        this.promotionalPrice = promotionalPrice;
    }

    @Override
    public int hashCode() {
        final int prime = 31;
        int result = 1;
        result = prime * result + ((id == null) ? 0 : id.hashCode());
        return result;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj)
            return true;
        if (obj == null)
            return false;
        if (getClass() != obj.getClass())
            return false;
        Travels other = (Travels) obj;
        if (id == null) {
            if (other.id != null)
                return false;
        } else if (!id.equals(other.id))
            return false;
        return true;
    }

    

}
