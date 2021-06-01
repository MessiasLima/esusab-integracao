/**
 * Autogenerated by Thrift Compiler (0.9.3)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
package br.gov.saude.esusab.ras.common;

import org.apache.thrift.scheme.IScheme;
import org.apache.thrift.scheme.SchemeFactory;
import org.apache.thrift.scheme.StandardScheme;

import org.apache.thrift.scheme.TupleScheme;
import org.apache.thrift.protocol.TTupleProtocol;
import org.apache.thrift.protocol.TProtocolException;
import org.apache.thrift.EncodingUtils;
import org.apache.thrift.TException;
import org.apache.thrift.async.AsyncMethodCallback;
import org.apache.thrift.server.AbstractNonblockingServer.*;
import java.util.List;
import java.util.ArrayList;
import java.util.Map;
import java.util.HashMap;
import java.util.EnumMap;
import java.util.Set;
import java.util.HashSet;
import java.util.EnumSet;
import java.util.Collections;
import java.util.BitSet;
import java.nio.ByteBuffer;
import java.util.Arrays;
import javax.annotation.Generated;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

@SuppressWarnings({"cast", "rawtypes", "serial", "unchecked"})
@Generated(value = "Autogenerated by Thrift Compiler (0.9.3)", date = "2021-05-04")
public class HeaderCdsCadastroThrift implements org.apache.thrift.TBase<HeaderCdsCadastroThrift, HeaderCdsCadastroThrift._Fields>, java.io.Serializable, Cloneable, Comparable<HeaderCdsCadastroThrift> {
  private static final org.apache.thrift.protocol.TStruct STRUCT_DESC = new org.apache.thrift.protocol.TStruct("HeaderCdsCadastroThrift");

  private static final org.apache.thrift.protocol.TField CNES_UNIDADE_SAUDE_FIELD_DESC = new org.apache.thrift.protocol.TField("cnesUnidadeSaude", org.apache.thrift.protocol.TType.STRING, (short)1);
  private static final org.apache.thrift.protocol.TField CNS_PROFISSIONAL_FIELD_DESC = new org.apache.thrift.protocol.TField("cnsProfissional", org.apache.thrift.protocol.TType.STRING, (short)2);
  private static final org.apache.thrift.protocol.TField CODIGO_IBGE_MUNICIPIO_FIELD_DESC = new org.apache.thrift.protocol.TField("codigoIbgeMunicipio", org.apache.thrift.protocol.TType.STRING, (short)3);
  private static final org.apache.thrift.protocol.TField DATA_ATENDIMENTO_FIELD_DESC = new org.apache.thrift.protocol.TField("dataAtendimento", org.apache.thrift.protocol.TType.I64, (short)4);
  private static final org.apache.thrift.protocol.TField INE_EQUIPE_FIELD_DESC = new org.apache.thrift.protocol.TField("ineEquipe", org.apache.thrift.protocol.TType.STRING, (short)5);
  private static final org.apache.thrift.protocol.TField MICROAREA_FIELD_DESC = new org.apache.thrift.protocol.TField("microarea", org.apache.thrift.protocol.TType.I64, (short)6);

  private static final Map<Class<? extends IScheme>, SchemeFactory> schemes = new HashMap<Class<? extends IScheme>, SchemeFactory>();
  static {
    schemes.put(StandardScheme.class, new HeaderCdsCadastroThriftStandardSchemeFactory());
    schemes.put(TupleScheme.class, new HeaderCdsCadastroThriftTupleSchemeFactory());
  }

  private String cnesUnidadeSaude; // optional
  private String cnsProfissional; // optional
  private String codigoIbgeMunicipio; // optional
  private long dataAtendimento; // optional
  private String ineEquipe; // optional
  private long microarea; // optional

  /** The set of fields this struct contains, along with convenience methods for finding and manipulating them. */
  public enum _Fields implements org.apache.thrift.TFieldIdEnum {
    CNES_UNIDADE_SAUDE((short)1, "cnesUnidadeSaude"),
    CNS_PROFISSIONAL((short)2, "cnsProfissional"),
    CODIGO_IBGE_MUNICIPIO((short)3, "codigoIbgeMunicipio"),
    DATA_ATENDIMENTO((short)4, "dataAtendimento"),
    INE_EQUIPE((short)5, "ineEquipe"),
    MICROAREA((short)6, "microarea");

    private static final Map<String, _Fields> byName = new HashMap<String, _Fields>();

    static {
      for (_Fields field : EnumSet.allOf(_Fields.class)) {
        byName.put(field.getFieldName(), field);
      }
    }

    /**
     * Find the _Fields constant that matches fieldId, or null if its not found.
     */
    public static _Fields findByThriftId(int fieldId) {
      switch(fieldId) {
        case 1: // CNES_UNIDADE_SAUDE
          return CNES_UNIDADE_SAUDE;
        case 2: // CNS_PROFISSIONAL
          return CNS_PROFISSIONAL;
        case 3: // CODIGO_IBGE_MUNICIPIO
          return CODIGO_IBGE_MUNICIPIO;
        case 4: // DATA_ATENDIMENTO
          return DATA_ATENDIMENTO;
        case 5: // INE_EQUIPE
          return INE_EQUIPE;
        case 6: // MICROAREA
          return MICROAREA;
        default:
          return null;
      }
    }

    /**
     * Find the _Fields constant that matches fieldId, throwing an exception
     * if it is not found.
     */
    public static _Fields findByThriftIdOrThrow(int fieldId) {
      _Fields fields = findByThriftId(fieldId);
      if (fields == null) throw new IllegalArgumentException("Field " + fieldId + " doesn't exist!");
      return fields;
    }

    /**
     * Find the _Fields constant that matches name, or null if its not found.
     */
    public static _Fields findByName(String name) {
      return byName.get(name);
    }

    private final short _thriftId;
    private final String _fieldName;

    _Fields(short thriftId, String fieldName) {
      _thriftId = thriftId;
      _fieldName = fieldName;
    }

    public short getThriftFieldId() {
      return _thriftId;
    }

    public String getFieldName() {
      return _fieldName;
    }
  }

  // isset id assignments
  private static final int __DATAATENDIMENTO_ISSET_ID = 0;
  private static final int __MICROAREA_ISSET_ID = 1;
  private byte __isset_bitfield = 0;
  private static final _Fields optionals[] = {_Fields.CNES_UNIDADE_SAUDE,_Fields.CNS_PROFISSIONAL,_Fields.CODIGO_IBGE_MUNICIPIO,_Fields.DATA_ATENDIMENTO,_Fields.INE_EQUIPE,_Fields.MICROAREA};
  public static final Map<_Fields, org.apache.thrift.meta_data.FieldMetaData> metaDataMap;
  static {
    Map<_Fields, org.apache.thrift.meta_data.FieldMetaData> tmpMap = new EnumMap<_Fields, org.apache.thrift.meta_data.FieldMetaData>(_Fields.class);
    tmpMap.put(_Fields.CNES_UNIDADE_SAUDE, new org.apache.thrift.meta_data.FieldMetaData("cnesUnidadeSaude", org.apache.thrift.TFieldRequirementType.OPTIONAL, 
        new org.apache.thrift.meta_data.FieldValueMetaData(org.apache.thrift.protocol.TType.STRING)));
    tmpMap.put(_Fields.CNS_PROFISSIONAL, new org.apache.thrift.meta_data.FieldMetaData("cnsProfissional", org.apache.thrift.TFieldRequirementType.OPTIONAL, 
        new org.apache.thrift.meta_data.FieldValueMetaData(org.apache.thrift.protocol.TType.STRING)));
    tmpMap.put(_Fields.CODIGO_IBGE_MUNICIPIO, new org.apache.thrift.meta_data.FieldMetaData("codigoIbgeMunicipio", org.apache.thrift.TFieldRequirementType.OPTIONAL, 
        new org.apache.thrift.meta_data.FieldValueMetaData(org.apache.thrift.protocol.TType.STRING)));
    tmpMap.put(_Fields.DATA_ATENDIMENTO, new org.apache.thrift.meta_data.FieldMetaData("dataAtendimento", org.apache.thrift.TFieldRequirementType.OPTIONAL, 
        new org.apache.thrift.meta_data.FieldValueMetaData(org.apache.thrift.protocol.TType.I64)));
    tmpMap.put(_Fields.INE_EQUIPE, new org.apache.thrift.meta_data.FieldMetaData("ineEquipe", org.apache.thrift.TFieldRequirementType.OPTIONAL, 
        new org.apache.thrift.meta_data.FieldValueMetaData(org.apache.thrift.protocol.TType.STRING)));
    tmpMap.put(_Fields.MICROAREA, new org.apache.thrift.meta_data.FieldMetaData("microarea", org.apache.thrift.TFieldRequirementType.OPTIONAL, 
        new org.apache.thrift.meta_data.FieldValueMetaData(org.apache.thrift.protocol.TType.I64)));
    metaDataMap = Collections.unmodifiableMap(tmpMap);
    org.apache.thrift.meta_data.FieldMetaData.addStructMetaDataMap(HeaderCdsCadastroThrift.class, metaDataMap);
  }

  public HeaderCdsCadastroThrift() {
  }

  /**
   * Performs a deep copy on <i>other</i>.
   */
  public HeaderCdsCadastroThrift(HeaderCdsCadastroThrift other) {
    __isset_bitfield = other.__isset_bitfield;
    if (other.isSetCnesUnidadeSaude()) {
      this.cnesUnidadeSaude = other.cnesUnidadeSaude;
    }
    if (other.isSetCnsProfissional()) {
      this.cnsProfissional = other.cnsProfissional;
    }
    if (other.isSetCodigoIbgeMunicipio()) {
      this.codigoIbgeMunicipio = other.codigoIbgeMunicipio;
    }
    this.dataAtendimento = other.dataAtendimento;
    if (other.isSetIneEquipe()) {
      this.ineEquipe = other.ineEquipe;
    }
    this.microarea = other.microarea;
  }

  public HeaderCdsCadastroThrift deepCopy() {
    return new HeaderCdsCadastroThrift(this);
  }

  @Override
  public void clear() {
    this.cnesUnidadeSaude = null;
    this.cnsProfissional = null;
    this.codigoIbgeMunicipio = null;
    setDataAtendimentoIsSet(false);
    this.dataAtendimento = 0;
    this.ineEquipe = null;
    setMicroareaIsSet(false);
    this.microarea = 0;
  }

  public String getCnesUnidadeSaude() {
    return this.cnesUnidadeSaude;
  }

  public void setCnesUnidadeSaude(String cnesUnidadeSaude) {
    this.cnesUnidadeSaude = cnesUnidadeSaude;
  }

  public void unsetCnesUnidadeSaude() {
    this.cnesUnidadeSaude = null;
  }

  /** Returns true if field cnesUnidadeSaude is set (has been assigned a value) and false otherwise */
  public boolean isSetCnesUnidadeSaude() {
    return this.cnesUnidadeSaude != null;
  }

  public void setCnesUnidadeSaudeIsSet(boolean value) {
    if (!value) {
      this.cnesUnidadeSaude = null;
    }
  }

  public String getCnsProfissional() {
    return this.cnsProfissional;
  }

  public void setCnsProfissional(String cnsProfissional) {
    this.cnsProfissional = cnsProfissional;
  }

  public void unsetCnsProfissional() {
    this.cnsProfissional = null;
  }

  /** Returns true if field cnsProfissional is set (has been assigned a value) and false otherwise */
  public boolean isSetCnsProfissional() {
    return this.cnsProfissional != null;
  }

  public void setCnsProfissionalIsSet(boolean value) {
    if (!value) {
      this.cnsProfissional = null;
    }
  }

  public String getCodigoIbgeMunicipio() {
    return this.codigoIbgeMunicipio;
  }

  public void setCodigoIbgeMunicipio(String codigoIbgeMunicipio) {
    this.codigoIbgeMunicipio = codigoIbgeMunicipio;
  }

  public void unsetCodigoIbgeMunicipio() {
    this.codigoIbgeMunicipio = null;
  }

  /** Returns true if field codigoIbgeMunicipio is set (has been assigned a value) and false otherwise */
  public boolean isSetCodigoIbgeMunicipio() {
    return this.codigoIbgeMunicipio != null;
  }

  public void setCodigoIbgeMunicipioIsSet(boolean value) {
    if (!value) {
      this.codigoIbgeMunicipio = null;
    }
  }

  public long getDataAtendimento() {
    return this.dataAtendimento;
  }

  public void setDataAtendimento(long dataAtendimento) {
    this.dataAtendimento = dataAtendimento;
    setDataAtendimentoIsSet(true);
  }

  public void unsetDataAtendimento() {
    __isset_bitfield = EncodingUtils.clearBit(__isset_bitfield, __DATAATENDIMENTO_ISSET_ID);
  }

  /** Returns true if field dataAtendimento is set (has been assigned a value) and false otherwise */
  public boolean isSetDataAtendimento() {
    return EncodingUtils.testBit(__isset_bitfield, __DATAATENDIMENTO_ISSET_ID);
  }

  public void setDataAtendimentoIsSet(boolean value) {
    __isset_bitfield = EncodingUtils.setBit(__isset_bitfield, __DATAATENDIMENTO_ISSET_ID, value);
  }

  public String getIneEquipe() {
    return this.ineEquipe;
  }

  public void setIneEquipe(String ineEquipe) {
    this.ineEquipe = ineEquipe;
  }

  public void unsetIneEquipe() {
    this.ineEquipe = null;
  }

  /** Returns true if field ineEquipe is set (has been assigned a value) and false otherwise */
  public boolean isSetIneEquipe() {
    return this.ineEquipe != null;
  }

  public void setIneEquipeIsSet(boolean value) {
    if (!value) {
      this.ineEquipe = null;
    }
  }

  public long getMicroarea() {
    return this.microarea;
  }

  public void setMicroarea(long microarea) {
    this.microarea = microarea;
    setMicroareaIsSet(true);
  }

  public void unsetMicroarea() {
    __isset_bitfield = EncodingUtils.clearBit(__isset_bitfield, __MICROAREA_ISSET_ID);
  }

  /** Returns true if field microarea is set (has been assigned a value) and false otherwise */
  public boolean isSetMicroarea() {
    return EncodingUtils.testBit(__isset_bitfield, __MICROAREA_ISSET_ID);
  }

  public void setMicroareaIsSet(boolean value) {
    __isset_bitfield = EncodingUtils.setBit(__isset_bitfield, __MICROAREA_ISSET_ID, value);
  }

  public void setFieldValue(_Fields field, Object value) {
    switch (field) {
    case CNES_UNIDADE_SAUDE:
      if (value == null) {
        unsetCnesUnidadeSaude();
      } else {
        setCnesUnidadeSaude((String)value);
      }
      break;

    case CNS_PROFISSIONAL:
      if (value == null) {
        unsetCnsProfissional();
      } else {
        setCnsProfissional((String)value);
      }
      break;

    case CODIGO_IBGE_MUNICIPIO:
      if (value == null) {
        unsetCodigoIbgeMunicipio();
      } else {
        setCodigoIbgeMunicipio((String)value);
      }
      break;

    case DATA_ATENDIMENTO:
      if (value == null) {
        unsetDataAtendimento();
      } else {
        setDataAtendimento((Long)value);
      }
      break;

    case INE_EQUIPE:
      if (value == null) {
        unsetIneEquipe();
      } else {
        setIneEquipe((String)value);
      }
      break;

    case MICROAREA:
      if (value == null) {
        unsetMicroarea();
      } else {
        setMicroarea((Long)value);
      }
      break;

    }
  }

  public Object getFieldValue(_Fields field) {
    switch (field) {
    case CNES_UNIDADE_SAUDE:
      return getCnesUnidadeSaude();

    case CNS_PROFISSIONAL:
      return getCnsProfissional();

    case CODIGO_IBGE_MUNICIPIO:
      return getCodigoIbgeMunicipio();

    case DATA_ATENDIMENTO:
      return getDataAtendimento();

    case INE_EQUIPE:
      return getIneEquipe();

    case MICROAREA:
      return getMicroarea();

    }
    throw new IllegalStateException();
  }

  /** Returns true if field corresponding to fieldID is set (has been assigned a value) and false otherwise */
  public boolean isSet(_Fields field) {
    if (field == null) {
      throw new IllegalArgumentException();
    }

    switch (field) {
    case CNES_UNIDADE_SAUDE:
      return isSetCnesUnidadeSaude();
    case CNS_PROFISSIONAL:
      return isSetCnsProfissional();
    case CODIGO_IBGE_MUNICIPIO:
      return isSetCodigoIbgeMunicipio();
    case DATA_ATENDIMENTO:
      return isSetDataAtendimento();
    case INE_EQUIPE:
      return isSetIneEquipe();
    case MICROAREA:
      return isSetMicroarea();
    }
    throw new IllegalStateException();
  }

  @Override
  public boolean equals(Object that) {
    if (that == null)
      return false;
    if (that instanceof HeaderCdsCadastroThrift)
      return this.equals((HeaderCdsCadastroThrift)that);
    return false;
  }

  public boolean equals(HeaderCdsCadastroThrift that) {
    if (that == null)
      return false;

    boolean this_present_cnesUnidadeSaude = true && this.isSetCnesUnidadeSaude();
    boolean that_present_cnesUnidadeSaude = true && that.isSetCnesUnidadeSaude();
    if (this_present_cnesUnidadeSaude || that_present_cnesUnidadeSaude) {
      if (!(this_present_cnesUnidadeSaude && that_present_cnesUnidadeSaude))
        return false;
      if (!this.cnesUnidadeSaude.equals(that.cnesUnidadeSaude))
        return false;
    }

    boolean this_present_cnsProfissional = true && this.isSetCnsProfissional();
    boolean that_present_cnsProfissional = true && that.isSetCnsProfissional();
    if (this_present_cnsProfissional || that_present_cnsProfissional) {
      if (!(this_present_cnsProfissional && that_present_cnsProfissional))
        return false;
      if (!this.cnsProfissional.equals(that.cnsProfissional))
        return false;
    }

    boolean this_present_codigoIbgeMunicipio = true && this.isSetCodigoIbgeMunicipio();
    boolean that_present_codigoIbgeMunicipio = true && that.isSetCodigoIbgeMunicipio();
    if (this_present_codigoIbgeMunicipio || that_present_codigoIbgeMunicipio) {
      if (!(this_present_codigoIbgeMunicipio && that_present_codigoIbgeMunicipio))
        return false;
      if (!this.codigoIbgeMunicipio.equals(that.codigoIbgeMunicipio))
        return false;
    }

    boolean this_present_dataAtendimento = true && this.isSetDataAtendimento();
    boolean that_present_dataAtendimento = true && that.isSetDataAtendimento();
    if (this_present_dataAtendimento || that_present_dataAtendimento) {
      if (!(this_present_dataAtendimento && that_present_dataAtendimento))
        return false;
      if (this.dataAtendimento != that.dataAtendimento)
        return false;
    }

    boolean this_present_ineEquipe = true && this.isSetIneEquipe();
    boolean that_present_ineEquipe = true && that.isSetIneEquipe();
    if (this_present_ineEquipe || that_present_ineEquipe) {
      if (!(this_present_ineEquipe && that_present_ineEquipe))
        return false;
      if (!this.ineEquipe.equals(that.ineEquipe))
        return false;
    }

    boolean this_present_microarea = true && this.isSetMicroarea();
    boolean that_present_microarea = true && that.isSetMicroarea();
    if (this_present_microarea || that_present_microarea) {
      if (!(this_present_microarea && that_present_microarea))
        return false;
      if (this.microarea != that.microarea)
        return false;
    }

    return true;
  }

  @Override
  public int hashCode() {
    List<Object> list = new ArrayList<Object>();

    boolean present_cnesUnidadeSaude = true && (isSetCnesUnidadeSaude());
    list.add(present_cnesUnidadeSaude);
    if (present_cnesUnidadeSaude)
      list.add(cnesUnidadeSaude);

    boolean present_cnsProfissional = true && (isSetCnsProfissional());
    list.add(present_cnsProfissional);
    if (present_cnsProfissional)
      list.add(cnsProfissional);

    boolean present_codigoIbgeMunicipio = true && (isSetCodigoIbgeMunicipio());
    list.add(present_codigoIbgeMunicipio);
    if (present_codigoIbgeMunicipio)
      list.add(codigoIbgeMunicipio);

    boolean present_dataAtendimento = true && (isSetDataAtendimento());
    list.add(present_dataAtendimento);
    if (present_dataAtendimento)
      list.add(dataAtendimento);

    boolean present_ineEquipe = true && (isSetIneEquipe());
    list.add(present_ineEquipe);
    if (present_ineEquipe)
      list.add(ineEquipe);

    boolean present_microarea = true && (isSetMicroarea());
    list.add(present_microarea);
    if (present_microarea)
      list.add(microarea);

    return list.hashCode();
  }

  @Override
  public int compareTo(HeaderCdsCadastroThrift other) {
    if (!getClass().equals(other.getClass())) {
      return getClass().getName().compareTo(other.getClass().getName());
    }

    int lastComparison = 0;

    lastComparison = Boolean.valueOf(isSetCnesUnidadeSaude()).compareTo(other.isSetCnesUnidadeSaude());
    if (lastComparison != 0) {
      return lastComparison;
    }
    if (isSetCnesUnidadeSaude()) {
      lastComparison = org.apache.thrift.TBaseHelper.compareTo(this.cnesUnidadeSaude, other.cnesUnidadeSaude);
      if (lastComparison != 0) {
        return lastComparison;
      }
    }
    lastComparison = Boolean.valueOf(isSetCnsProfissional()).compareTo(other.isSetCnsProfissional());
    if (lastComparison != 0) {
      return lastComparison;
    }
    if (isSetCnsProfissional()) {
      lastComparison = org.apache.thrift.TBaseHelper.compareTo(this.cnsProfissional, other.cnsProfissional);
      if (lastComparison != 0) {
        return lastComparison;
      }
    }
    lastComparison = Boolean.valueOf(isSetCodigoIbgeMunicipio()).compareTo(other.isSetCodigoIbgeMunicipio());
    if (lastComparison != 0) {
      return lastComparison;
    }
    if (isSetCodigoIbgeMunicipio()) {
      lastComparison = org.apache.thrift.TBaseHelper.compareTo(this.codigoIbgeMunicipio, other.codigoIbgeMunicipio);
      if (lastComparison != 0) {
        return lastComparison;
      }
    }
    lastComparison = Boolean.valueOf(isSetDataAtendimento()).compareTo(other.isSetDataAtendimento());
    if (lastComparison != 0) {
      return lastComparison;
    }
    if (isSetDataAtendimento()) {
      lastComparison = org.apache.thrift.TBaseHelper.compareTo(this.dataAtendimento, other.dataAtendimento);
      if (lastComparison != 0) {
        return lastComparison;
      }
    }
    lastComparison = Boolean.valueOf(isSetIneEquipe()).compareTo(other.isSetIneEquipe());
    if (lastComparison != 0) {
      return lastComparison;
    }
    if (isSetIneEquipe()) {
      lastComparison = org.apache.thrift.TBaseHelper.compareTo(this.ineEquipe, other.ineEquipe);
      if (lastComparison != 0) {
        return lastComparison;
      }
    }
    lastComparison = Boolean.valueOf(isSetMicroarea()).compareTo(other.isSetMicroarea());
    if (lastComparison != 0) {
      return lastComparison;
    }
    if (isSetMicroarea()) {
      lastComparison = org.apache.thrift.TBaseHelper.compareTo(this.microarea, other.microarea);
      if (lastComparison != 0) {
        return lastComparison;
      }
    }
    return 0;
  }

  public _Fields fieldForId(int fieldId) {
    return _Fields.findByThriftId(fieldId);
  }

  public void read(org.apache.thrift.protocol.TProtocol iprot) throws org.apache.thrift.TException {
    schemes.get(iprot.getScheme()).getScheme().read(iprot, this);
  }

  public void write(org.apache.thrift.protocol.TProtocol oprot) throws org.apache.thrift.TException {
    schemes.get(oprot.getScheme()).getScheme().write(oprot, this);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder("HeaderCdsCadastroThrift(");
    boolean first = true;

    if (isSetCnesUnidadeSaude()) {
      sb.append("cnesUnidadeSaude:");
      if (this.cnesUnidadeSaude == null) {
        sb.append("null");
      } else {
        sb.append(this.cnesUnidadeSaude);
      }
      first = false;
    }
    if (isSetCnsProfissional()) {
      if (!first) sb.append(", ");
      sb.append("cnsProfissional:");
      if (this.cnsProfissional == null) {
        sb.append("null");
      } else {
        sb.append(this.cnsProfissional);
      }
      first = false;
    }
    if (isSetCodigoIbgeMunicipio()) {
      if (!first) sb.append(", ");
      sb.append("codigoIbgeMunicipio:");
      if (this.codigoIbgeMunicipio == null) {
        sb.append("null");
      } else {
        sb.append(this.codigoIbgeMunicipio);
      }
      first = false;
    }
    if (isSetDataAtendimento()) {
      if (!first) sb.append(", ");
      sb.append("dataAtendimento:");
      sb.append(this.dataAtendimento);
      first = false;
    }
    if (isSetIneEquipe()) {
      if (!first) sb.append(", ");
      sb.append("ineEquipe:");
      if (this.ineEquipe == null) {
        sb.append("null");
      } else {
        sb.append(this.ineEquipe);
      }
      first = false;
    }
    if (isSetMicroarea()) {
      if (!first) sb.append(", ");
      sb.append("microarea:");
      sb.append(this.microarea);
      first = false;
    }
    sb.append(")");
    return sb.toString();
  }

  public void validate() throws org.apache.thrift.TException {
    // check for required fields
    // check for sub-struct validity
  }

  private void writeObject(java.io.ObjectOutputStream out) throws java.io.IOException {
    try {
      write(new org.apache.thrift.protocol.TCompactProtocol(new org.apache.thrift.transport.TIOStreamTransport(out)));
    } catch (org.apache.thrift.TException te) {
      throw new java.io.IOException(te);
    }
  }

  private void readObject(java.io.ObjectInputStream in) throws java.io.IOException, ClassNotFoundException {
    try {
      // it doesn't seem like you should have to do this, but java serialization is wacky, and doesn't call the default constructor.
      __isset_bitfield = 0;
      read(new org.apache.thrift.protocol.TCompactProtocol(new org.apache.thrift.transport.TIOStreamTransport(in)));
    } catch (org.apache.thrift.TException te) {
      throw new java.io.IOException(te);
    }
  }

  private static class HeaderCdsCadastroThriftStandardSchemeFactory implements SchemeFactory {
    public HeaderCdsCadastroThriftStandardScheme getScheme() {
      return new HeaderCdsCadastroThriftStandardScheme();
    }
  }

  private static class HeaderCdsCadastroThriftStandardScheme extends StandardScheme<HeaderCdsCadastroThrift> {

    public void read(org.apache.thrift.protocol.TProtocol iprot, HeaderCdsCadastroThrift struct) throws org.apache.thrift.TException {
      org.apache.thrift.protocol.TField schemeField;
      iprot.readStructBegin();
      while (true)
      {
        schemeField = iprot.readFieldBegin();
        if (schemeField.type == org.apache.thrift.protocol.TType.STOP) { 
          break;
        }
        switch (schemeField.id) {
          case 1: // CNES_UNIDADE_SAUDE
            if (schemeField.type == org.apache.thrift.protocol.TType.STRING) {
              struct.cnesUnidadeSaude = iprot.readString();
              struct.setCnesUnidadeSaudeIsSet(true);
            } else { 
              org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
            }
            break;
          case 2: // CNS_PROFISSIONAL
            if (schemeField.type == org.apache.thrift.protocol.TType.STRING) {
              struct.cnsProfissional = iprot.readString();
              struct.setCnsProfissionalIsSet(true);
            } else { 
              org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
            }
            break;
          case 3: // CODIGO_IBGE_MUNICIPIO
            if (schemeField.type == org.apache.thrift.protocol.TType.STRING) {
              struct.codigoIbgeMunicipio = iprot.readString();
              struct.setCodigoIbgeMunicipioIsSet(true);
            } else { 
              org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
            }
            break;
          case 4: // DATA_ATENDIMENTO
            if (schemeField.type == org.apache.thrift.protocol.TType.I64) {
              struct.dataAtendimento = iprot.readI64();
              struct.setDataAtendimentoIsSet(true);
            } else { 
              org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
            }
            break;
          case 5: // INE_EQUIPE
            if (schemeField.type == org.apache.thrift.protocol.TType.STRING) {
              struct.ineEquipe = iprot.readString();
              struct.setIneEquipeIsSet(true);
            } else { 
              org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
            }
            break;
          case 6: // MICROAREA
            if (schemeField.type == org.apache.thrift.protocol.TType.I64) {
              struct.microarea = iprot.readI64();
              struct.setMicroareaIsSet(true);
            } else { 
              org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
            }
            break;
          default:
            org.apache.thrift.protocol.TProtocolUtil.skip(iprot, schemeField.type);
        }
        iprot.readFieldEnd();
      }
      iprot.readStructEnd();
      struct.validate();
    }

    public void write(org.apache.thrift.protocol.TProtocol oprot, HeaderCdsCadastroThrift struct) throws org.apache.thrift.TException {
      struct.validate();

      oprot.writeStructBegin(STRUCT_DESC);
      if (struct.cnesUnidadeSaude != null) {
        if (struct.isSetCnesUnidadeSaude()) {
          oprot.writeFieldBegin(CNES_UNIDADE_SAUDE_FIELD_DESC);
          oprot.writeString(struct.cnesUnidadeSaude);
          oprot.writeFieldEnd();
        }
      }
      if (struct.cnsProfissional != null) {
        if (struct.isSetCnsProfissional()) {
          oprot.writeFieldBegin(CNS_PROFISSIONAL_FIELD_DESC);
          oprot.writeString(struct.cnsProfissional);
          oprot.writeFieldEnd();
        }
      }
      if (struct.codigoIbgeMunicipio != null) {
        if (struct.isSetCodigoIbgeMunicipio()) {
          oprot.writeFieldBegin(CODIGO_IBGE_MUNICIPIO_FIELD_DESC);
          oprot.writeString(struct.codigoIbgeMunicipio);
          oprot.writeFieldEnd();
        }
      }
      if (struct.isSetDataAtendimento()) {
        oprot.writeFieldBegin(DATA_ATENDIMENTO_FIELD_DESC);
        oprot.writeI64(struct.dataAtendimento);
        oprot.writeFieldEnd();
      }
      if (struct.ineEquipe != null) {
        if (struct.isSetIneEquipe()) {
          oprot.writeFieldBegin(INE_EQUIPE_FIELD_DESC);
          oprot.writeString(struct.ineEquipe);
          oprot.writeFieldEnd();
        }
      }
      if (struct.isSetMicroarea()) {
        oprot.writeFieldBegin(MICROAREA_FIELD_DESC);
        oprot.writeI64(struct.microarea);
        oprot.writeFieldEnd();
      }
      oprot.writeFieldStop();
      oprot.writeStructEnd();
    }

  }

  private static class HeaderCdsCadastroThriftTupleSchemeFactory implements SchemeFactory {
    public HeaderCdsCadastroThriftTupleScheme getScheme() {
      return new HeaderCdsCadastroThriftTupleScheme();
    }
  }

  private static class HeaderCdsCadastroThriftTupleScheme extends TupleScheme<HeaderCdsCadastroThrift> {

    @Override
    public void write(org.apache.thrift.protocol.TProtocol prot, HeaderCdsCadastroThrift struct) throws org.apache.thrift.TException {
      TTupleProtocol oprot = (TTupleProtocol) prot;
      BitSet optionals = new BitSet();
      if (struct.isSetCnesUnidadeSaude()) {
        optionals.set(0);
      }
      if (struct.isSetCnsProfissional()) {
        optionals.set(1);
      }
      if (struct.isSetCodigoIbgeMunicipio()) {
        optionals.set(2);
      }
      if (struct.isSetDataAtendimento()) {
        optionals.set(3);
      }
      if (struct.isSetIneEquipe()) {
        optionals.set(4);
      }
      if (struct.isSetMicroarea()) {
        optionals.set(5);
      }
      oprot.writeBitSet(optionals, 6);
      if (struct.isSetCnesUnidadeSaude()) {
        oprot.writeString(struct.cnesUnidadeSaude);
      }
      if (struct.isSetCnsProfissional()) {
        oprot.writeString(struct.cnsProfissional);
      }
      if (struct.isSetCodigoIbgeMunicipio()) {
        oprot.writeString(struct.codigoIbgeMunicipio);
      }
      if (struct.isSetDataAtendimento()) {
        oprot.writeI64(struct.dataAtendimento);
      }
      if (struct.isSetIneEquipe()) {
        oprot.writeString(struct.ineEquipe);
      }
      if (struct.isSetMicroarea()) {
        oprot.writeI64(struct.microarea);
      }
    }

    @Override
    public void read(org.apache.thrift.protocol.TProtocol prot, HeaderCdsCadastroThrift struct) throws org.apache.thrift.TException {
      TTupleProtocol iprot = (TTupleProtocol) prot;
      BitSet incoming = iprot.readBitSet(6);
      if (incoming.get(0)) {
        struct.cnesUnidadeSaude = iprot.readString();
        struct.setCnesUnidadeSaudeIsSet(true);
      }
      if (incoming.get(1)) {
        struct.cnsProfissional = iprot.readString();
        struct.setCnsProfissionalIsSet(true);
      }
      if (incoming.get(2)) {
        struct.codigoIbgeMunicipio = iprot.readString();
        struct.setCodigoIbgeMunicipioIsSet(true);
      }
      if (incoming.get(3)) {
        struct.dataAtendimento = iprot.readI64();
        struct.setDataAtendimentoIsSet(true);
      }
      if (incoming.get(4)) {
        struct.ineEquipe = iprot.readString();
        struct.setIneEquipeIsSet(true);
      }
      if (incoming.get(5)) {
        struct.microarea = iprot.readI64();
        struct.setMicroareaIsSet(true);
      }
    }
  }

}

