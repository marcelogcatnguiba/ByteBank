﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ByteBank.Entities
{
    internal class ContaCorrente
    {
        public Titular Titular { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; } 
        public double Saldo { get; set; }

        // Construtores
        public ContaCorrente()
        {
        }
        public ContaCorrente(Titular titular, int agencia, int conta, double saldo)
        {
            Titular = titular;
            Agencia = agencia;
            Conta = conta;
            Saldo = saldo;
        }

        // ToString override
        public override string ToString()
        {
            return $"Titular: {Titular.Nome} \n"+
                   $"CPF: {Titular.Cpf} \n" +
                   $"Profissão: {Titular.Profissao} \n" +
                   $"Agencia: {Agencia} \n" +
                   $"Conta: {Conta} \n" +
                   $"Saldo: {Saldo} \n";
        }

        //Metodos
        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public bool Saque(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
                return false;
            }
        }

        public void Tranferencia(double valor, ContaCorrente conta)
        {
            bool teste = Saque(valor);
            if(teste == true)
            {
                conta.Deposito(valor);
            }
        }
    }
}