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

namespace br.gov.saude.esusab.ras.atendodonto
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class FichaAtendimentoOdontologicoChildThrift : TBase
  {
    private long _dtNascimento;
    private string _cnsCidadao;
    private string _numProntuario;
    private bool _gestante;
    private bool _necessidadesEspeciais;
    private long _localAtendimento;
    private long _tipoAtendimento;
    private List<long> _tiposEncamOdonto;
    private List<long> _tiposFornecimOdonto;
    private List<long> _tiposVigilanciaSaudeBucal;
    private List<long> _tiposConsultaOdonto;
    private List<ProcedimentoQuantidadeThrift> _procedimentosRealizados;
    private long _sexo;
    private long _turno;
    private long _dataHoraInicialAtendimento;
    private long _dataHoraFinalAtendimento;
    private string _cpfCidadao;
    private List<br.gov.saude.esusab.ras.common.MedicamentoThrift> _medicamentos;
    private List<br.gov.saude.esusab.ras.common.EncaminhamentoExternoThrift> _encaminhamentos;
    private List<br.gov.saude.esusab.ras.common.ResultadosExameThrift> _resultadosExames;

    public long DtNascimento
    {
      get
      {
        return _dtNascimento;
      }
      set
      {
        __isset.dtNascimento = true;
        this._dtNascimento = value;
      }
    }

    public string CnsCidadao
    {
      get
      {
        return _cnsCidadao;
      }
      set
      {
        __isset.cnsCidadao = true;
        this._cnsCidadao = value;
      }
    }

    public string NumProntuario
    {
      get
      {
        return _numProntuario;
      }
      set
      {
        __isset.numProntuario = true;
        this._numProntuario = value;
      }
    }

    public bool Gestante
    {
      get
      {
        return _gestante;
      }
      set
      {
        __isset.gestante = true;
        this._gestante = value;
      }
    }

    public bool NecessidadesEspeciais
    {
      get
      {
        return _necessidadesEspeciais;
      }
      set
      {
        __isset.necessidadesEspeciais = true;
        this._necessidadesEspeciais = value;
      }
    }

    public long LocalAtendimento
    {
      get
      {
        return _localAtendimento;
      }
      set
      {
        __isset.localAtendimento = true;
        this._localAtendimento = value;
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

    public List<long> TiposEncamOdonto
    {
      get
      {
        return _tiposEncamOdonto;
      }
      set
      {
        __isset.tiposEncamOdonto = true;
        this._tiposEncamOdonto = value;
      }
    }

    public List<long> TiposFornecimOdonto
    {
      get
      {
        return _tiposFornecimOdonto;
      }
      set
      {
        __isset.tiposFornecimOdonto = true;
        this._tiposFornecimOdonto = value;
      }
    }

    public List<long> TiposVigilanciaSaudeBucal
    {
      get
      {
        return _tiposVigilanciaSaudeBucal;
      }
      set
      {
        __isset.tiposVigilanciaSaudeBucal = true;
        this._tiposVigilanciaSaudeBucal = value;
      }
    }

    public List<long> TiposConsultaOdonto
    {
      get
      {
        return _tiposConsultaOdonto;
      }
      set
      {
        __isset.tiposConsultaOdonto = true;
        this._tiposConsultaOdonto = value;
      }
    }

    public List<ProcedimentoQuantidadeThrift> ProcedimentosRealizados
    {
      get
      {
        return _procedimentosRealizados;
      }
      set
      {
        __isset.procedimentosRealizados = true;
        this._procedimentosRealizados = value;
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

    public List<br.gov.saude.esusab.ras.common.ResultadosExameThrift> ResultadosExames
    {
      get
      {
        return _resultadosExames;
      }
      set
      {
        __isset.resultadosExames = true;
        this._resultadosExames = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool dtNascimento;
      public bool cnsCidadao;
      public bool numProntuario;
      public bool gestante;
      public bool necessidadesEspeciais;
      public bool localAtendimento;
      public bool tipoAtendimento;
      public bool tiposEncamOdonto;
      public bool tiposFornecimOdonto;
      public bool tiposVigilanciaSaudeBucal;
      public bool tiposConsultaOdonto;
      public bool procedimentosRealizados;
      public bool sexo;
      public bool turno;
      public bool dataHoraInicialAtendimento;
      public bool dataHoraFinalAtendimento;
      public bool cpfCidadao;
      public bool medicamentos;
      public bool encaminhamentos;
      public bool resultadosExames;
    }

    public FichaAtendimentoOdontologicoChildThrift() {
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
              if (field.Type == TType.I64) {
                DtNascimento = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                CnsCidadao = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                NumProntuario = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Bool) {
                Gestante = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.Bool) {
                NecessidadesEspeciais = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.I64) {
                LocalAtendimento = iprot.ReadI64();
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
              if (field.Type == TType.List) {
                {
                  TiposEncamOdonto = new List<long>();
                  TList _list0 = iprot.ReadListBegin();
                  for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                  {
                    long _elem2;
                    _elem2 = iprot.ReadI64();
                    TiposEncamOdonto.Add(_elem2);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.List) {
                {
                  TiposFornecimOdonto = new List<long>();
                  TList _list3 = iprot.ReadListBegin();
                  for( int _i4 = 0; _i4 < _list3.Count; ++_i4)
                  {
                    long _elem5;
                    _elem5 = iprot.ReadI64();
                    TiposFornecimOdonto.Add(_elem5);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 10:
              if (field.Type == TType.List) {
                {
                  TiposVigilanciaSaudeBucal = new List<long>();
                  TList _list6 = iprot.ReadListBegin();
                  for( int _i7 = 0; _i7 < _list6.Count; ++_i7)
                  {
                    long _elem8;
                    _elem8 = iprot.ReadI64();
                    TiposVigilanciaSaudeBucal.Add(_elem8);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 11:
              if (field.Type == TType.List) {
                {
                  TiposConsultaOdonto = new List<long>();
                  TList _list9 = iprot.ReadListBegin();
                  for( int _i10 = 0; _i10 < _list9.Count; ++_i10)
                  {
                    long _elem11;
                    _elem11 = iprot.ReadI64();
                    TiposConsultaOdonto.Add(_elem11);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 12:
              if (field.Type == TType.List) {
                {
                  ProcedimentosRealizados = new List<ProcedimentoQuantidadeThrift>();
                  TList _list12 = iprot.ReadListBegin();
                  for( int _i13 = 0; _i13 < _list12.Count; ++_i13)
                  {
                    ProcedimentoQuantidadeThrift _elem14;
                    _elem14 = new ProcedimentoQuantidadeThrift();
                    _elem14.Read(iprot);
                    ProcedimentosRealizados.Add(_elem14);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 14:
              if (field.Type == TType.I64) {
                Sexo = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 15:
              if (field.Type == TType.I64) {
                Turno = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 16:
              if (field.Type == TType.I64) {
                DataHoraInicialAtendimento = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 17:
              if (field.Type == TType.I64) {
                DataHoraFinalAtendimento = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 18:
              if (field.Type == TType.String) {
                CpfCidadao = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 19:
              if (field.Type == TType.List) {
                {
                  Medicamentos = new List<br.gov.saude.esusab.ras.common.MedicamentoThrift>();
                  TList _list15 = iprot.ReadListBegin();
                  for( int _i16 = 0; _i16 < _list15.Count; ++_i16)
                  {
                    br.gov.saude.esusab.ras.common.MedicamentoThrift _elem17;
                    _elem17 = new br.gov.saude.esusab.ras.common.MedicamentoThrift();
                    _elem17.Read(iprot);
                    Medicamentos.Add(_elem17);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 20:
              if (field.Type == TType.List) {
                {
                  Encaminhamentos = new List<br.gov.saude.esusab.ras.common.EncaminhamentoExternoThrift>();
                  TList _list18 = iprot.ReadListBegin();
                  for( int _i19 = 0; _i19 < _list18.Count; ++_i19)
                  {
                    br.gov.saude.esusab.ras.common.EncaminhamentoExternoThrift _elem20;
                    _elem20 = new br.gov.saude.esusab.ras.common.EncaminhamentoExternoThrift();
                    _elem20.Read(iprot);
                    Encaminhamentos.Add(_elem20);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 21:
              if (field.Type == TType.List) {
                {
                  ResultadosExames = new List<br.gov.saude.esusab.ras.common.ResultadosExameThrift>();
                  TList _list21 = iprot.ReadListBegin();
                  for( int _i22 = 0; _i22 < _list21.Count; ++_i22)
                  {
                    br.gov.saude.esusab.ras.common.ResultadosExameThrift _elem23;
                    _elem23 = new br.gov.saude.esusab.ras.common.ResultadosExameThrift();
                    _elem23.Read(iprot);
                    ResultadosExames.Add(_elem23);
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
        TStruct struc = new TStruct("FichaAtendimentoOdontologicoChildThrift");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.dtNascimento) {
          field.Name = "dtNascimento";
          field.Type = TType.I64;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(DtNascimento);
          oprot.WriteFieldEnd();
        }
        if (CnsCidadao != null && __isset.cnsCidadao) {
          field.Name = "cnsCidadao";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(CnsCidadao);
          oprot.WriteFieldEnd();
        }
        if (NumProntuario != null && __isset.numProntuario) {
          field.Name = "numProntuario";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(NumProntuario);
          oprot.WriteFieldEnd();
        }
        if (__isset.gestante) {
          field.Name = "gestante";
          field.Type = TType.Bool;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(Gestante);
          oprot.WriteFieldEnd();
        }
        if (__isset.necessidadesEspeciais) {
          field.Name = "necessidadesEspeciais";
          field.Type = TType.Bool;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(NecessidadesEspeciais);
          oprot.WriteFieldEnd();
        }
        if (__isset.localAtendimento) {
          field.Name = "localAtendimento";
          field.Type = TType.I64;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(LocalAtendimento);
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
        if (TiposEncamOdonto != null && __isset.tiposEncamOdonto) {
          field.Name = "tiposEncamOdonto";
          field.Type = TType.List;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.I64, TiposEncamOdonto.Count));
            foreach (long _iter24 in TiposEncamOdonto)
            {
              oprot.WriteI64(_iter24);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (TiposFornecimOdonto != null && __isset.tiposFornecimOdonto) {
          field.Name = "tiposFornecimOdonto";
          field.Type = TType.List;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.I64, TiposFornecimOdonto.Count));
            foreach (long _iter25 in TiposFornecimOdonto)
            {
              oprot.WriteI64(_iter25);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (TiposVigilanciaSaudeBucal != null && __isset.tiposVigilanciaSaudeBucal) {
          field.Name = "tiposVigilanciaSaudeBucal";
          field.Type = TType.List;
          field.ID = 10;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.I64, TiposVigilanciaSaudeBucal.Count));
            foreach (long _iter26 in TiposVigilanciaSaudeBucal)
            {
              oprot.WriteI64(_iter26);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (TiposConsultaOdonto != null && __isset.tiposConsultaOdonto) {
          field.Name = "tiposConsultaOdonto";
          field.Type = TType.List;
          field.ID = 11;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.I64, TiposConsultaOdonto.Count));
            foreach (long _iter27 in TiposConsultaOdonto)
            {
              oprot.WriteI64(_iter27);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (ProcedimentosRealizados != null && __isset.procedimentosRealizados) {
          field.Name = "procedimentosRealizados";
          field.Type = TType.List;
          field.ID = 12;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, ProcedimentosRealizados.Count));
            foreach (ProcedimentoQuantidadeThrift _iter28 in ProcedimentosRealizados)
            {
              _iter28.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (__isset.sexo) {
          field.Name = "sexo";
          field.Type = TType.I64;
          field.ID = 14;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(Sexo);
          oprot.WriteFieldEnd();
        }
        if (__isset.turno) {
          field.Name = "turno";
          field.Type = TType.I64;
          field.ID = 15;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(Turno);
          oprot.WriteFieldEnd();
        }
        if (__isset.dataHoraInicialAtendimento) {
          field.Name = "dataHoraInicialAtendimento";
          field.Type = TType.I64;
          field.ID = 16;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(DataHoraInicialAtendimento);
          oprot.WriteFieldEnd();
        }
        if (__isset.dataHoraFinalAtendimento) {
          field.Name = "dataHoraFinalAtendimento";
          field.Type = TType.I64;
          field.ID = 17;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(DataHoraFinalAtendimento);
          oprot.WriteFieldEnd();
        }
        if (CpfCidadao != null && __isset.cpfCidadao) {
          field.Name = "cpfCidadao";
          field.Type = TType.String;
          field.ID = 18;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(CpfCidadao);
          oprot.WriteFieldEnd();
        }
        if (Medicamentos != null && __isset.medicamentos) {
          field.Name = "medicamentos";
          field.Type = TType.List;
          field.ID = 19;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Medicamentos.Count));
            foreach (br.gov.saude.esusab.ras.common.MedicamentoThrift _iter29 in Medicamentos)
            {
              _iter29.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (Encaminhamentos != null && __isset.encaminhamentos) {
          field.Name = "encaminhamentos";
          field.Type = TType.List;
          field.ID = 20;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Encaminhamentos.Count));
            foreach (br.gov.saude.esusab.ras.common.EncaminhamentoExternoThrift _iter30 in Encaminhamentos)
            {
              _iter30.Write(oprot);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        if (ResultadosExames != null && __isset.resultadosExames) {
          field.Name = "resultadosExames";
          field.Type = TType.List;
          field.ID = 21;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, ResultadosExames.Count));
            foreach (br.gov.saude.esusab.ras.common.ResultadosExameThrift _iter31 in ResultadosExames)
            {
              _iter31.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("FichaAtendimentoOdontologicoChildThrift(");
      bool __first = true;
      if (__isset.dtNascimento) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DtNascimento: ");
        __sb.Append(DtNascimento);
      }
      if (CnsCidadao != null && __isset.cnsCidadao) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("CnsCidadao: ");
        __sb.Append(CnsCidadao);
      }
      if (NumProntuario != null && __isset.numProntuario) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NumProntuario: ");
        __sb.Append(NumProntuario);
      }
      if (__isset.gestante) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Gestante: ");
        __sb.Append(Gestante);
      }
      if (__isset.necessidadesEspeciais) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("NecessidadesEspeciais: ");
        __sb.Append(NecessidadesEspeciais);
      }
      if (__isset.localAtendimento) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("LocalAtendimento: ");
        __sb.Append(LocalAtendimento);
      }
      if (__isset.tipoAtendimento) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TipoAtendimento: ");
        __sb.Append(TipoAtendimento);
      }
      if (TiposEncamOdonto != null && __isset.tiposEncamOdonto) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TiposEncamOdonto: ");
        __sb.Append(TiposEncamOdonto);
      }
      if (TiposFornecimOdonto != null && __isset.tiposFornecimOdonto) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TiposFornecimOdonto: ");
        __sb.Append(TiposFornecimOdonto);
      }
      if (TiposVigilanciaSaudeBucal != null && __isset.tiposVigilanciaSaudeBucal) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TiposVigilanciaSaudeBucal: ");
        __sb.Append(TiposVigilanciaSaudeBucal);
      }
      if (TiposConsultaOdonto != null && __isset.tiposConsultaOdonto) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TiposConsultaOdonto: ");
        __sb.Append(TiposConsultaOdonto);
      }
      if (ProcedimentosRealizados != null && __isset.procedimentosRealizados) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ProcedimentosRealizados: ");
        __sb.Append(ProcedimentosRealizados);
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
      if (ResultadosExames != null && __isset.resultadosExames) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ResultadosExames: ");
        __sb.Append(ResultadosExames);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
