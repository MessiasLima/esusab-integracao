/**
 * Autogenerated by Thrift Compiler (0.9.3)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace br.gov.saude.esusab.ras.atendindividual
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class FichaAtendimentoIndividualChildThrift : TBase
  {
    private string _numeroProntuario;
    private string _cns;
    private long _dataNascimento;
    private long _localDeAtendimento;
    private long _sexo;
    private long _turno;
    private long _tipoAtendimento;
    private double _pesoAcompanhamentoNutricional;
    private double _alturaAcompanhamentoNutricional;
    private long _aleitamentoMaterno;
    private long _dumDaGestante;
    private int _idadeGestacional;
    private long _atencaoDomiciliarModalidade;
    private ProblemaCondicaoAvaliacaoAIThrift _problemaCondicaoAvaliada;
    private List<ExameThrift> _exame;
    private bool _vacinaEmDia;
    private long _pic;
    private bool _ficouEmObservacao;
    private List<long> _nasfs;
    private List<long> _condutas;
    private bool _stGravidezPlanejada;
    private int _nuGestasPrevias;
    private int _nuPartos;
    private long _racionalidadeSaude;
    private double _perimetroCefalico;
    private long _dataHoraInicialAtendimento;
    private long _dataHoraFinalAtendimento;
    private string _cpfCidadao;
    private List<br.gov.saude.esusab.ras.common.MedicamentoThrift> _medicamentos;
    private List<br.gov.saude.esusab.ras.common.EncaminhamentoExternoThrift> _encaminhamentos;

    public string NumeroProntuario
    {
      get
      {
        return _numeroProntuario;
      }
      set
      {
        __isset.numeroProntuario = true;
        this._numeroProntuario = value;
      }
    }

    public string Cns
    {
      get
      {
        return _cns;
      }
      set
      {
        __isset.cns = true;
        this._cns = value;
      }
    }

    public long DataNascimento
    {
      get
      {
        return _dataNascimento;
      }
      set
      {
        __isset.dataNascimento = true;
        this._dataNascimento = value;
      }
    }

    public long LocalDeAtendimento
    {
      get
      {
        return _localDeAtendimento;
      }
      set
      {
        __isset.localDeAtendimento = true;
        this._localDeAtendimento = value;
      }
    }

    public long Sexo
    {
      get
      {
        return _sexo;
      }
      set
      {
        __isset.sexo = true;
        this._sexo = value;
      }
    }

    public long Turno
    {
      get
      {
        return _turno;
      }
      set
      {
        __isset.turno = true;
        this._turno = value;
      }
    }

    public long TipoAtendimento
    {
      get
      {
        return _tipoAtendimento;
      }
      set
      {
        __isset.tipoAtendimento = true;
        this._tipoAtendimento = value;
      }
    }

    public double PesoAcompanhamentoNutricional
    {
      get
      {
        return _pesoAcompanhamentoNutricional;
      }
      set
      {
        __isset.pesoAcompanhamentoNutricional = true;
        this._pesoAcompanhamentoNutricional = value;
      }
    }

    public double AlturaAcompanhamentoNutricional
    {
      get
      {
        return _alturaAcompanhamentoNutricional;
      }
      set
      {
        __isset.alturaAcompanhamentoNutricional = true;
        this._alturaAcompanhamentoNutricional = value;
      }
    }

    public long AleitamentoMaterno
    {
      get
      {
        return _aleitamentoMaterno;
      }
      set
      {
        __isset.aleitamentoMaterno = true;
        this._aleitamentoMaterno = value;
      }
    }

    public long DumDaGestante
    {
      get
      {
        return _dumDaGestante;
      }
      set
      {
        __isset.dumDaGestante = true;
        this._dumDaGestante = value;
      }
    }

    public int IdadeGestacional
    {
      get
      {
        return _idadeGestacional;
      }
      set
      {
        __isset.idadeGestacional = true;
        this._idadeGestacional = value;
      }
    }

    public long AtencaoDomiciliarModalidade
    {
      get
      {
        return _atencaoDomiciliarModalidade;
      }
      set
      {
        __isset.atencaoDomiciliarModalidade = true;
        this._atencaoDomiciliarModalidade = value;
      }
    }

    public ProblemaCondicaoAvaliacaoAIThrift ProblemaCondicaoAvaliada
    {
      get
      {
        return _problemaCondicaoAvaliada;
      }
      set
      {
        __isset.problemaCondicaoAvaliada = true;
        this._problemaCondicaoAvaliada = value;
      }
    }

    public List<ExameThrift> Exame
    {
      get
      {
        return _exame;
      }
      set
      {
        __isset.exame = true;
        this._exame = value;
      }
    }

    public bool VacinaEmDia
    {
      get
      {
        return _vacinaEmDia;
      }
      set
      {
        __isset.vacinaEmDia = true;
        this._vacinaEmDia = value;
      }
    }

    public long Pic
    {
      get
      {
        return _pic;
      }
      set
      {
        __isset.pic = true;
        this._pic = value;
      }
    }

    public bool FicouEmObservacao
    {
      get
      {
        return _ficouEmObservacao;
      }
      set
      {
        __isset.ficouEmObservacao = true;
        this._ficouEmObservacao = value;
      }
    }

    public List<long> Nasfs
    {
      get
      {
        return _nasfs;
      }
      set
      {
        __isset.nasfs = true;
        this._nasfs = value;
      }
    }

    public List<long> Condutas
    {
      get
      {
        return _condutas;
      }
      set
      {
        __isset.condutas = true;
        this._condutas = value;
      }
    }

    public bool StGravidezPlanejada
    {
      get
      {
        return _stGravidezPlanejada;
      }
      set
      {
        __isset.stGravidezPlanejada = true;
        this._stGravidezPlanejada = value;
      }
    }

    public int NuGestasPrevias
    {
      get
      {
        return _nuGestasPrevias;
      }
      set
      {
        __isset.nuGestasPrevias = true;
        this._nuGestasPrevias = value;
      }
    }

    public int NuPartos
    {
      get
      {
        return _nuPartos;
      }
      set
      {
        __isset.nuPartos = true;
        this._nuPartos = value;
      }
    }

    public long RacionalidadeSaude
    {
      get
      {
        return _racionalidadeSaude;
      }
      set
      {
        __isset.racionalidadeSaude = true;
        this._racionalidadeSaude = value;
      }
    }

    public double PerimetroCefalico
    {
      get
      {
        return _perimetroCefalico;
      }
      set
      {
        __isset.perimetroCefalico = true;
        this._perimetroCefalico = value;
      }
    }

    public long DataHoraInicialAtendimento
    {
      get
      {
        return _dataHoraInicialAtendimento;
      }
      set
      {
        __isset.dataHoraInicialAtendimento = true;
        this._dataHoraInicialAtendimento = value;
      }
    }

    public long DataHoraFinalAtendimento
    {
      get
      {
        return _dataHoraFinalAtendimento;
      }
      set
      {
        __isset.dataHoraFinalAtendimento = true;
        this._dataHoraFinalAtendimento = value;
      }
    }

    public string CpfCidadao
    {
      get
      {
        return _cpfCidadao;
      }
      set
      {
        __isset.cpfCidadao = true;
        this._cpfCidadao = value;
      }
    }

    public List<br.gov.saude.esusab.ras.common.MedicamentoThrift> Medicamentos
    {
      get
      {
        return _medicamentos;
      }
      set
      {
        __isset.medicamentos = true;
        this._medicamentos = value;
      }
    }

    public List<br.gov.saude.esusab.ras.common.EncaminhamentoExternoThrift> Encaminhamentos
    {
      get
      {
        return _encaminhamentos;
      }
      set
      {
        __isset.encaminhamentos = true;
        this._encaminhamentos = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool numeroProntuario;
      public bool cns;
      public bool dataNascimento;
      public bool localDeAtendimento;
      public bool sexo;
      public bool turno;
      public bool tipoAtendimento;
      public bool pesoAcompanhamentoNutricional;
      public bool alturaAcompanhamentoNutricional;
      public bool aleitamentoMaterno;
      public bool dumDaGestante;
      public bool idadeGestacional;
      public bool atencaoDomiciliarModalidade;
      public bool problemaCondicaoAvaliada;
      public bool exame;
      public bool vacinaEmDia;
      public bool pic;
      public bool ficouEmObservacao;
      public bool nasfs;
      public bool condutas;
      public bool stGravidezPlanejada;
      public bool nuGestasPrevias;
      public bool nuPartos;
      public bool racionalidadeSaude;
      public bool perimetroCefalico;
      public bool dataHoraInicialAtendimento;
      public bool dataHoraFinalAtendimento;
      public bool cpfCidadao;
      public bool medicamentos;
      public bool encaminhamentos;
    }

    public FichaAtendimentoIndividualChildThrift() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                NumeroProntuario = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Cns = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I64) {
                DataNascimento = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.I64) {
                LocalDeAtendimento = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.I64) {
                Sexo = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.I64) {
                Turno = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.I64) {
                TipoAtendimento = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.Double) {
                PesoAcompanhamentoNutricional = iprot.ReadDouble();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.Double) {
                AlturaAcompanhamentoNutricional = iprot.ReadDouble();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 10:
              if (field.Type == TType.I64) {
                AleitamentoMaterno = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 11:
              if (field.Type == TType.I64) {
                DumDaGestante = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 12:
              if (field.Type == TType.I32) {
                IdadeGestacional = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 13:
              if (field.Type == TType.I64) {
                AtencaoDomiciliarModalidade = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 14:
              if (field.Type == TType.Struct) {
                ProblemaCondicaoAvaliada = new ProblemaCondicaoAvaliacaoAIThrift();
                ProblemaCondicaoAvaliada.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 17:
              if (field.Type == TType.List) {
                {
                  Exame = new List<ExameThrift>();
                  TList _list8 = iprot.ReadListBegin();
                  for( int _i9 = 0; _i9 < _list8.Count; ++_i9)
                  {
                    ExameThrift _elem10;
                    _elem10 = new ExameThrift();
                    _elem10.Read(iprot);
                    Exame.Add(_elem10);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 18:
              if (field.Type == TType.Bool) {
                VacinaEmDia = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 19:
              if (field.Type == TType.I64) {
                Pic = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 20:
              if (field.Type == TType.Bool) {
                FicouEmObservacao = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 21:
              if (field.Type == TType.List) {
                {
                  Nasfs = new List<long>();
                  TList _list11 = iprot.ReadListBegin();
                  for( int _i12 = 0; _i12 < _list11.Count; ++_i12)
                  {
                    long _elem13;
                    _elem13 = iprot.ReadI64();
                    Nasfs.Add(_elem13);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 22:
              if (field.Type == TType.List) {
                {
                  Condutas = new List<long>();
                  TList _list14 = iprot.ReadListBegin();
                  for( int _i15 = 0; _i15 < _list14.Count; ++_i15)
                  {
                    long _elem16;
                    _elem16 = iprot.ReadI64();
                    Condutas.Add(_elem16);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 23:
              if (field.Type == TType.Bool) {
                StGravidezPlanejada = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 24:
              if (field.Type == TType.I32) {
                NuGestasPrevias = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 25:
              if (field.Type == TType.I32) {
                NuPartos = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 26:
              if (field.Type == TType.I64) {
                RacionalidadeSaude = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 27:
              if (field.Type == TType.Double) {
                PerimetroCefalico = iprot.ReadDouble();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 28:
              if (field.Type == TType.I64) {
                DataHoraInicialAtendimento = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 29:
              if (field.Type == TType.I64) {
                DataHoraFinalAtendimento = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 30:
              if (field.Type == TType.String) {
                CpfCidadao = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 31:
              if (field.Type == TType.List) {
                {
                  Medicamentos = new List<br.gov.saude.esusab.ras.common.MedicamentoThrift>();
                  TList _list17 = iprot.ReadListBegin();
                  for( int _i18 = 0; _i18 < _list17.Count; ++_i18)
                  {
                    br.gov.saude.esusab.ras.common.MedicamentoThrift _elem19;
                    _elem19 = new br.gov.saude.esusab.ras.common.MedicamentoThrift();
                    _elem19.Read(iprot);
                    Medicamentos.Add(_elem19);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 32:
              if (field.Type == TType.List) {
                {
                  Encaminhamentos = new List<br.gov.saude.esusab.ras.common.EncaminhamentoExternoThrift>();
                  TList _list20 = iprot.ReadListBegin();
                  for( int _i21 = 0; _i21 < _list20.Count; ++_i21)
                  {
                    br.gov.saude.esusab.ras.common.EncaminhamentoExternoThrift _elem22;
                    _elem22 = new br.gov.saude.esusab.ras.common.EncaminhamentoExternoThrift();
                    _elem22.Read(iprot);
                    Encaminhamentos.Add(_elem22);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("FichaAtendimentoIndividualChildThrift");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (NumeroProntuario != null && __isset.numeroProntuario) {
          field.Name = "numeroProntuario";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(NumeroProntuario);
          oprot.WriteFieldEnd();
        }
        if (Cns != null && __isset.cns) {
          field.Name = "cns";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Cns);
          oprot.WriteFieldEnd();
        }
        if (__isset.dataNascimento) {
          field.Name = "dataNascimento";
          field.Type = TType.I64;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(DataNascimento);
          oprot.WriteFieldEnd();
        }
        if (__isset.localDeAtendimento) {
          field.Name = "localDeAtendimento";
          field.Type = TType.I64;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(LocalDeAtendimento);
          oprot.WriteFieldEnd();
        }
        if (__isset.sexo) {
          field.Name = "sexo";
          field.Type = TType.I64;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(Sexo);
          oprot.WriteFieldEnd();
        }
        if (__isset.turno) {
          field.Name = "turno";
          field.Type = TType.I64;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(Turno);
          oprot.WriteFieldEnd();
        }
        if (__isset.tipoAtendimento) {
          field.Name = "tipoAtendimento";
          field.Type = TType.I64;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(TipoAtendimento);
          oprot.WriteFieldEnd();
        }
        if (__isset.pesoAcompanhamentoNutricional) {
          field.Name = "pesoAcompanhamentoNutricional";
          field.Type = TType.Double;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteDouble(PesoAcompanhamentoNutricional);
          oprot.WriteFieldEnd();
        }
        if (__isset.alturaAcompanhamentoNutricional) {
          field.Name = "alturaAcompanhamentoNutricional";
          field.Type = TType.Double;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          oprot.WriteDouble(AlturaAcompanhamentoNutricional);
          oprot.WriteFieldEnd();
        }
        if (__isset.aleitamentoMaterno) {
          field.Name = "aleitamentoMaterno";
          field.Type = TType.I64;
          field.ID = 10;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(AleitamentoMaterno);
          oprot.WriteFieldEnd();
        }
        if (__isset.dumDaGestante) {
          field.Name = "dumDaGestante";
          field.Type = TType.I64;
          field.ID = 11;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(DumDaGestante);
          oprot.WriteFieldEnd();
        }
        if (__isset.idadeGestacional) {
          field.Name = "idadeGestacional";
          field.Type = TType.I32;
          field.ID = 12;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(IdadeGestacional);
          oprot.WriteFieldEnd();
        }
        if (__isset.atencaoDomiciliarModalidade) {
          field.Name = "atencaoDomiciliarModalidade";
          field.Type = TType.I64;
          field.ID = 13;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(AtencaoDomiciliarModalidade);
          oprot.WriteFieldEnd();
        }
        if (ProblemaCondicaoAvaliada != null && __isset.problemaCondicaoAvaliada) {
          field.Name = "problemaCondicaoAvaliada";
          field.Type = TType.Struct;
          field.ID = 14;
          oprot.WriteFieldBegin(field);
          ProblemaCondicaoAvaliada.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Exame != null && __isset.exame) {
          field.Name = "exame";
          field.Type = TType.List;
          field.ID = 17;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Exame.Count));
            foreach (ExameThrift _iter23 in Exame)
            {
              _iter23.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (__isset.vacinaEmDia) {
          field.Name = "vacinaEmDia";
          field.Type = TType.Bool;
          field.ID = 18;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(VacinaEmDia);
          oprot.WriteFieldEnd();
        }
        if (__isset.pic) {
          field.Name = "pic";
          field.Type = TType.I64;
          field.ID = 19;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(Pic);
          oprot.WriteFieldEnd();
        }
        if (__isset.ficouEmObservacao) {
          field.Name = "ficouEmObservacao";
          field.Type = TType.Bool;
          field.ID = 20;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(FicouEmObservacao);
          oprot.WriteFieldEnd();
        }
        if (Nasfs != null && __isset.nasfs) {
          field.Name = "nasfs";
          field.Type = TType.List;
          field.ID = 21;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.I64, Nasfs.Count));
            foreach (long _iter24 in Nasfs)
            {
              oprot.WriteI64(_iter24);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (Condutas != null && __isset.condutas) {
          field.Name = "condutas";
          field.Type = TType.List;
          field.ID = 22;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.I64, Condutas.Count));
            foreach (long _iter25 in Condutas)
            {
              oprot.WriteI64(_iter25);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (__isset.stGravidezPlanejada) {
          field.Name = "stGravidezPlanejada";
          field.Type = TType.Bool;
          field.ID = 23;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(StGravidezPlanejada);
          oprot.WriteFieldEnd();
        }
        if (__isset.nuGestasPrevias) {
          field.Name = "nuGestasPrevias";
          field.Type = TType.I32;
          field.ID = 24;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(NuGestasPrevias);
          oprot.WriteFieldEnd();
        }
        if (__isset.nuPartos) {
          field.Name = "nuPartos";
          field.Type = TType.I32;
          field.ID = 25;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(NuPartos);
          oprot.WriteFieldEnd();
        }
        if (__isset.racionalidadeSaude) {
          field.Name = "racionalidadeSaude";
          field.Type = TType.I64;
          field.ID = 26;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(RacionalidadeSaude);
          oprot.WriteFieldEnd();
        }
        if (__isset.perimetroCefalico) {
          field.Name = "perimetroCefalico";
          field.Type = TType.Double;
          field.ID = 27;
          oprot.WriteFieldBegin(field);
          oprot.WriteDouble(PerimetroCefalico);
          oprot.WriteFieldEnd();
        }
        if (__isset.dataHoraInicialAtendimento) {
          field.Name = "dataHoraInicialAtendimento";
          field.Type = TType.I64;
          field.ID = 28;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(DataHoraInicialAtendimento);
          oprot.WriteFieldEnd();
        }
        if (__isset.dataHoraFinalAtendimento) {
          field.Name = "dataHoraFinalAtendimento";
          field.Type = TType.I64;
          field.ID = 29;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(DataHoraFinalAtendimento);
          oprot.WriteFieldEnd();
        }
        if (CpfCidadao != null && __isset.cpfCidadao) {
          field.Name = "cpfCidadao";
          field.Type = TType.String;
          field.ID = 30;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(CpfCidadao);
          oprot.WriteFieldEnd();
        }
        if (Medicamentos != null && __isset.medicamentos) {
          field.Name = "medicamentos";
          field.Type = TType.List;
          field.ID = 31;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Medicamentos.Count));
            foreach (br.gov.saude.esusab.ras.common.MedicamentoThrift _iter26 in Medicamentos)
            {
              _iter26.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (Encaminhamentos != null && __isset.encaminhamentos) {
          field.Name = "encaminhamentos";
          field.Type = TType.List;
          field.ID = 32;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Encaminhamentos.Count));
            foreach (br.gov.saude.esusab.ras.common.EncaminhamentoExternoThrift _iter27 in Encaminhamentos)
            {
              _iter27.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("FichaAtendimentoIndividualChildThrift(");
      bool __first = true;
      if (NumeroProntuario != null && __isset.numeroProntuario) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NumeroProntuario: ");
        __sb.Append(NumeroProntuario);
      }
      if (Cns != null && __isset.cns) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Cns: ");
        __sb.Append(Cns);
      }
      if (__isset.dataNascimento) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DataNascimento: ");
        __sb.Append(DataNascimento);
      }
      if (__isset.localDeAtendimento) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("LocalDeAtendimento: ");
        __sb.Append(LocalDeAtendimento);
      }
      if (__isset.sexo) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Sexo: ");
        __sb.Append(Sexo);
      }
      if (__isset.turno) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Turno: ");
        __sb.Append(Turno);
      }
      if (__isset.tipoAtendimento) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TipoAtendimento: ");
        __sb.Append(TipoAtendimento);
      }
      if (__isset.pesoAcompanhamentoNutricional) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("PesoAcompanhamentoNutricional: ");
        __sb.Append(PesoAcompanhamentoNutricional);
      }
      if (__isset.alturaAcompanhamentoNutricional) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("AlturaAcompanhamentoNutricional: ");
        __sb.Append(AlturaAcompanhamentoNutricional);
      }
      if (__isset.aleitamentoMaterno) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("AleitamentoMaterno: ");
        __sb.Append(AleitamentoMaterno);
      }
      if (__isset.dumDaGestante) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DumDaGestante: ");
        __sb.Append(DumDaGestante);
      }
      if (__isset.idadeGestacional) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IdadeGestacional: ");
        __sb.Append(IdadeGestacional);
      }
      if (__isset.atencaoDomiciliarModalidade) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("AtencaoDomiciliarModalidade: ");
        __sb.Append(AtencaoDomiciliarModalidade);
      }
      if (ProblemaCondicaoAvaliada != null && __isset.problemaCondicaoAvaliada) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ProblemaCondicaoAvaliada: ");
        __sb.Append(ProblemaCondicaoAvaliada== null ? "<null>" : ProblemaCondicaoAvaliada.ToString());
      }
      if (Exame != null && __isset.exame) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Exame: ");
        __sb.Append(Exame);
      }
      if (__isset.vacinaEmDia) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("VacinaEmDia: ");
        __sb.Append(VacinaEmDia);
      }
      if (__isset.pic) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Pic: ");
        __sb.Append(Pic);
      }
      if (__isset.ficouEmObservacao) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("FicouEmObservacao: ");
        __sb.Append(FicouEmObservacao);
      }
      if (Nasfs != null && __isset.nasfs) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Nasfs: ");
        __sb.Append(Nasfs);
      }
      if (Condutas != null && __isset.condutas) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Condutas: ");
        __sb.Append(Condutas);
      }
      if (__isset.stGravidezPlanejada) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StGravidezPlanejada: ");
        __sb.Append(StGravidezPlanejada);
      }
      if (__isset.nuGestasPrevias) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NuGestasPrevias: ");
        __sb.Append(NuGestasPrevias);
      }
      if (__isset.nuPartos) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NuPartos: ");
        __sb.Append(NuPartos);
      }
      if (__isset.racionalidadeSaude) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("RacionalidadeSaude: ");
        __sb.Append(RacionalidadeSaude);
      }
      if (__isset.perimetroCefalico) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("PerimetroCefalico: ");
        __sb.Append(PerimetroCefalico);
      }
      if (__isset.dataHoraInicialAtendimento) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DataHoraInicialAtendimento: ");
        __sb.Append(DataHoraInicialAtendimento);
      }
      if (__isset.dataHoraFinalAtendimento) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DataHoraFinalAtendimento: ");
        __sb.Append(DataHoraFinalAtendimento);
      }
      if (CpfCidadao != null && __isset.cpfCidadao) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("CpfCidadao: ");
        __sb.Append(CpfCidadao);
      }
      if (Medicamentos != null && __isset.medicamentos) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Medicamentos: ");
        __sb.Append(Medicamentos);
      }
      if (Encaminhamentos != null && __isset.encaminhamentos) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Encaminhamentos: ");
        __sb.Append(Encaminhamentos);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
