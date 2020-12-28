Feature: Book store

Scenario: Book store init and working
  Given Book store
  When Book store init
  Then worker and deliver getting ready
  When Book store start working
  Then worker and deliver are working