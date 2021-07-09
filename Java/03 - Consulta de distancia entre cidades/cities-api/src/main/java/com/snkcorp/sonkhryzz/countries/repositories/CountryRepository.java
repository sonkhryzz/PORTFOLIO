package com.snkcorp.sonkhryzz.countries.repositories;

import com.snkcorp.sonkhryzz.countries.entities.Country;
import org.springframework.data.jpa.repository.JpaRepository;

public interface CountryRepository extends JpaRepository<Country, Long> {
}
